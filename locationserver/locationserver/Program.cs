using System;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace locationserver
{
    class Program
    {
        static Dictionary<string, string> userlocations = new Dictionary<string, string>();

        public static Logging log;

        static void Main(string[] args)
        {
            string filename = null;
            string savedata = null;
            //This loop is for testing for commands within the server command line and setting the variables
            for (int i = 0; i < args.Length; ++i)
            {
                switch (args[i])
                {
                    case "-l":
                        filename = args[++i];
                        break;
                    case "-f":
                        savedata = args[++i];
                        break;
                    case "-w":
                        var serverui = new serverUI();
                        Application.Run(serverui);
                        List<string> calledlist = serverui.GetList();
                        break;
                    default:
                        Console.WriteLine("Unknown Command" + args[i]);
                        break;
                }
            }

            //Creates a new instance of the logging class
            log = new Logging(filename);
            runServer();

        }

        static void runServer()
        {
            TcpListener listener;
            Socket connection;
            Handler RequestHandler;
            try
            {
                listener = new TcpListener(IPAddress.Any, 43);
                //Starts the server listening for a connection
                listener.Start();
                Console.WriteLine("Server is Listening");
                while (true)
                {
                    //This handles multiple threads for my server, so it can handle multiple connections at once
                    connection = listener.AcceptSocket();
                    RequestHandler = new Handler();
                    Thread t = new Thread(() => RequestHandler.doRequest(connection, log));
                    t.Start();
                }
            }
            catch (Exception e)
            {
                //Output exception to the console window if the server doesn't manage to connect
                Console.WriteLine("Exception: " + e.ToString());
            }
        }

        class Handler
        {
            public void doRequest(Socket connection, Logging log)
            {
                //Checks for a connection
                string Host = ((IPEndPoint)connection.RemoteEndPoint).Address.ToString();
                NetworkStream socketStream;
                socketStream = new NetworkStream(connection);
                Console.WriteLine("Connection Received");
                string status = "OK";
                string input = "";

                try
                {
                    //Sets server timeouts
                    socketStream.ReadTimeout = 1000;
                    socketStream.WriteTimeout = 1000;
                    StreamWriter sw = new StreamWriter(socketStream);
                    StreamReader sr = new StreamReader(socketStream);
                    
                    string response = string.Empty;
                    //Pulls in the content sent from a connected client character by character
                    while (sr.Peek() >= 0)
                    {
                        input += (char)sr.Read();
                    }

                    //Split the content on the carriage returns so the array is equal to each individual line
                    string[] contentarray = input.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                    string requesttype = null;

                    //checks content array to select a requesttype
                    if (contentarray[0].Length >= 6)
                    {
                        requesttype = contentarray[0].Substring(0, 6);
                    }
                    else
                    {
                        requesttype = contentarray[0].Substring(0, 1);
                    }

                    //Switches on the requesttype
                    switch (requesttype)
                    {
                        case "GET /?":

                            if (contentarray[0].EndsWith("HTTP/1.1"))
                            {
                                //Controls the HTTP/1.1 GET requests
                                string[] usernamegetter = contentarray[0].Split('=');
                                string username = usernamegetter[1].Split(' ').First();
                                if (userlocations.ContainsKey(username))
                                {
                                    userlocations.TryGetValue(username, out string value);
                                    sw.Write("HTTP/1.1 200 OK\r\nContent-Type: text/plain\r\n\r\n" + value + "\r\n");
                                    sw.Flush();
                                }
                                else
                                {
                                    sw.Write("HTTP/1.1 404 Not Found\r\nContent-Type: text/plain\r\n\r\n");
                                    sw.Flush();
                                }
                            }
                            else
                            {
                                //Controls the HTTP/1.0 GET requests
                                string[] usernamegetter = contentarray[0].Split('?');
                                string username = usernamegetter[1].Split(' ').First();
                                if (userlocations.ContainsKey(username))
                                {
                                    userlocations.TryGetValue(username, out string value);
                                    sw.Write("HTTP/1.0 200 OK\r\nContent-Type: text/plain\r\n\r\n" + value + "\r\n");
                                    sw.Flush();
                                }
                                else
                                {
                                    sw.Write("HTTP/1.0 404 Not Found\r\nContent-Type: text/plain\r\n\r\n");
                                    sw.Flush();
                                }
                            }
                            break;

                        case "POST /":
                            if (contentarray.Length > 3) //1.1
                            {
                                //Controls the HTTP/1.1 POST requests
                                string[] userlocsplit = contentarray[3].Split(new char[] { '&' });
                                string username = userlocsplit[0].Split('=').Last();
                                string location = userlocsplit[1].Split('=').Last();
                                if (userlocations.ContainsKey(username))
                                {
                                    userlocations.Remove(username);
                                    userlocations.Add(username, location);
                                    string sendpostlocation = ("HTTP/1.1 200 OK\r\nContent-Type: text/plain\r\n\r\n");
                                    sw.Write(sendpostlocation);
                                    sw.Flush();
                                }
                                else
                                {
                                    userlocations.Add(username, location);
                                    string sendpostlocation = ("HTTP/1.1 200 OK\r\nContent-Type: text/plain\r\n\r\n");
                                    sw.Write(sendpostlocation);
                                    sw.Flush();
                                }
                            }
                            else //1.0
                            {
                                //Controls the HTTP/1.0 POST requests
                                string[] usersplit = contentarray[0].Split('/');
                                string username = usersplit[1].Split(' ').First();
                                string location = contentarray[2];
                                if (userlocations.ContainsKey(username))
                                {
                                    userlocations.Remove(username);
                                    userlocations.Add(username, location);
                                    string sendpostlocation = ("HTTP/1.0 200 OK\r\nContent-Type: text/plain\r\n\r\n");
                                    sw.Write(sendpostlocation);
                                    sw.Flush();
                                }
                                else
                                {
                                    userlocations.Add(username, location);
                                    string sendpostlocation = ("HTTP/1.0 200 OK\r\nContent-Type: text/plain\r\n\r\n");
                                    sw.Write(sendpostlocation);
                                    sw.Flush();
                                }

                            }
                            break;

                        default:
                            if (requesttype.StartsWith("GET /"))
                            {
                                //Controls the HTTP/0.9 GET requests
                                string username = contentarray[0].Split('/').Last();
                                if (userlocations.ContainsKey(username))
                                {
                                    userlocations.TryGetValue(username, out string value);
                                    sw.Write("HTTP/0.9 200 OK\r\nContent-Type: text/plain\r\n\r\n" + value + "\r\n");
                                    sw.Flush();
                                }
                                else if (!userlocations.ContainsKey(username))
                                {
                                    sw.Write("HTTP/0.9 404 Not Found\r\nContent-Type: text/plain\r\n\r\n");
                                    sw.Flush();
                                }
                            }
                            else if (requesttype.StartsWith("PUT /"))
                            {
                                //Controls the HTTP/0.9 PUT requests
                                string username = contentarray[0].Split('/').Last();
                                string location = contentarray[1];
                                if (userlocations.ContainsKey(username))
                                {
                                    userlocations.Remove(username);
                                    userlocations.Add(username, location);
                                    sw.WriteLine("HTTP/0.9 200 OK\r\nContent-Type: text/plain\r\n\r\n");
                                    sw.Flush();
                                }
                                else if (!userlocations.ContainsKey(username))
                                {
                                    userlocations.Add(username, location);
                                    sw.WriteLine("HTTP/0.9 200 OK\r\nContent-Type: text/plain\r\n\r\n");
                                    sw.Flush();
                                }
                            }
                            else
                            {
                                //If it's none of the protocols then it's the standard whois request
                                //Controls the WHOIS GET requests
                                string[] splitarray = contentarray[0].Split(' ');
                                if (splitarray.Length == 1)
                                {
                                    if (!userlocations.ContainsKey(splitarray[0]))
                                    {
                                        sw.Write("ERROR: no entries found");
                                        sw.Flush();
                                    }
                                    else if (userlocations.ContainsKey(splitarray[0]))
                                    {
                                        userlocations.TryGetValue(splitarray[0], out string value);
                                        sw.Write(value);
                                        sw.Flush();
                                    }
                                }
                                else if (splitarray.Length >= 2)
                                {
                                    //If it isn't the GET request then it's the PUT request
                                    //Controls the WHOIS PUT requests
                                    string location = null;
                                    for (int i = 1; i < splitarray.Length; i++)
                                    {
                                        string locationsplit = splitarray[i].ToString();
                                        location += locationsplit + " ";
                                    }
                                    location = location.Trim();

                                    if (!userlocations.ContainsKey(splitarray[0]))
                                    {
                                        userlocations.Add(splitarray[0], location);
                                        sw.Write("OK");
                                        sw.Flush();
                                    }
                                    else
                                    {
                                        userlocations.Remove(splitarray[0]);
                                        userlocations.Add(splitarray[0], location);
                                        sw.Write("OK");
                                        sw.Flush();
                                    }

                                }

                                break;
                            }
                            break;
                    }

                }
                catch
                {

                }
                finally
                {
                    //At the very end of the program make sure to close all connections and output to the log file (if any)
                    socketStream.Close();
                    connection.Close();
                    log.WriteToLog(Host,input,status);
                }


            }
        }
    }
}
