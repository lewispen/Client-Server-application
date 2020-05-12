using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace location
{
    class Program
    {
        //Consolemode boolean let's the program know if the UI is running or not
        static bool consoleMode = true;
        static void Main(string[] args)
        {
            RunClient(args);
        }

        public static void RunClient(string[] args)
        {
            try
            {
                #region clientsettings
                var clientSetup = new ClientSetup(); //Setting up the default settings, entering the clientsetup constructor

                //UI Launching if the args are equal to 0
                if (args.Length == 0)
                {
                    consoleMode = false;
                    var clientinterface = new ClientInterface();
                    Application.Run(clientinterface);
                    List<string> calledlist = clientinterface.GetList();
                    args = calledlist.ToArray();
                }

                clientSetup.AdvancedSetup(args); //Setting up the Username & Location without UI

                TcpClient client = new TcpClient(); //Creating a new instance of the client
                client.Connect(clientSetup.Connection, clientSetup.Port); //Setting Con and Port
                client.ReceiveTimeout = clientSetup.Timeout; //Timeout
                client.SendTimeout = clientSetup.Timeout; //Timeout
                StreamWriter sw = new StreamWriter(client.GetStream());//Opening streamwriter
                StreamReader sr = new StreamReader(client.GetStream());//Opening streamreader

                //Setting based on advanced setup
                string username = clientSetup.Username;
                string location = clientSetup.Location;
                string protocol = clientSetup.Protocol;

                //If username doesn't exist then there are too few arguements for the program to continue
                if (username == null)
                {
                    if (consoleMode)
                    {
                        Console.WriteLine("ERROR: Too Few Arguements");
                    }
                    else
                    {
                        MessageBox.Show("ERROR: Too Few Arguements","Arguement Error");
                    }
                    
                }
                #endregion
                #region protocol
                //Protocol switch statement, this controls which protocol the program will execute
                switch (protocol)
                {
                    #region whois
                    case "whois":
                        if (location == null)
                        {
                            //whois request that controls the default protocol
                            sw.WriteLine(username);
                            sw.Flush();
                            string response = null; 
                            while (!sr.EndOfStream)
                            {
                                response += sr.ReadLine() + " ";
                            }
                            //If the response we receive starts with ERROR: then the result will enter this loop
                            if (response.StartsWith("ERROR:"))
                            {
                                if (consoleMode)
                                {
                                    Console.Write("ERROR: no entries found");
                                }
                                else
                                {
                                    MessageBox.Show("ERROR: no entries found");
                                }
                            }
                            else
                            {
                                //If the response doesn't start with ERROR: then the result will enter this loop
                                //and display the search results sent by the server
                                response = response.Trim();
                                if (consoleMode)
                                {
                                    Console.Write(username + " is " + response);
                                }
                                else
                                {
                                    MessageBox.Show(username + " is " + response, "Search Result");
                                }
                                
                            }

                        }
                        else
                        {
                            //If the request isn't a GET request then it's a PUT request and enters this section
                            sw.WriteLine(username + " " + location);
                            sw.Flush();
                            string response = sr.ReadLine();
                            //If we receive a positive response from the server we enter this statement
                            if (response == "OK")
                            {
                                if (consoleMode)
                                {
                                    Console.Write(username + " location changed to be " + location);
                                }
                                else
                                {
                                    MessageBox.Show(username + " location changed to be " + location,"Location Change");
                                }
                            }
                            //This part of the program should not be reached unless the server sends up a request we aren't capable of handling
                            else
                            {
                                Console.Write("ERROR: Not Expected Response");
                            }
                        }
                        break;
                    #endregion
                    #region 0.9
                    case "-h9":
                        if (location == null)
                        {
                            sw.WriteLine("GET /" + username);
                            sw.Flush();
                            string response = sr.ReadLine();
                            //404 is the standard for when an entry cannot be found, if we receive this then we know there are no entries in the database
                            //for the username we're searching for
                            if (response.Contains("404"))
                            {
                                if (consoleMode)
                                {
                                    Console.Write("ERROR: no entries found");
                                }
                                else
                                {
                                    MessageBox.Show("ERROR: no entries found");
                                }
                                
                            }
                            else
                            {
                                //This loop appends all the content from the server into one string
                                while (!sr.EndOfStream)
                                {
                                    response += sr.ReadLine() + " ";
                                }
                                //We split the string into an array of 5 and remove any empty entries
                                string[] splitarray = response.Split((string[])null, 5, StringSplitOptions.RemoveEmptyEntries);
                                //We trim the result we want so it has no blanks at the start or the end of the string
                                string finallocation = splitarray[4].Trim();
                                if (consoleMode)
                                {
                                    Console.Write(username + " is " + finallocation);
                                }
                                else
                                {
                                    MessageBox.Show(username + " is " + finallocation,"Search Result");
                                }
                                
                            }
                        }
                        else
                        {
                            //The content add section for the 0.9 request
                            sw.WriteLine("PUT /" + username);
                            sw.WriteLine();
                            sw.WriteLine(location);
                            sw.Flush();
                            string reply = sr.ReadLine();
                            //If our reply is what we expect "OK" then we enter the location to the database
                            if (reply.EndsWith("OK"))
                            {
                                if (consoleMode)
                                {
                                    Console.Write(username + " location changed to be " + location);
                                }
                                else
                                {
                                    MessageBox.Show(username + " location changed to be " + location,"Location Change");
                                }
                                
                            }
                        }
                        break;
                    #endregion
                    #region 1.0
                    case "-h0":
                        //If our location is null then we know we are going to be handling a GET request
                        if (location == null)
                        {
                            //Sending the correct request to the server
                            sw.Write("GET" + " " + "/?" + username + " " + "HTTP/1.0" + "\r\n\r\n");
                            sw.Flush();
                            string firstreply = sr.ReadLine();
                            string response = null;
                            //Checking the first reply we receive to check if it is the value we expected it to be
                            if (firstreply.Contains("404"))
                            {
                                if (consoleMode)
                                {
                                    Console.Write("ERROR: no entries found");
                                }
                                else
                                {
                                    MessageBox.Show("ERROR: no entries found");
                                }
                                
                            }
                            else
                            {
                                //Appending readline to string
                                while (!sr.EndOfStream)
                                {
                                    response += sr.ReadLine() + " ";
                                }
                                string[] splitarray = response.Split((string[])null, 3, StringSplitOptions.RemoveEmptyEntries);
                                string finallocation = splitarray[2].Trim();
                                if (consoleMode)
                                {
                                    Console.Write(username + " is " + finallocation);
                                }
                                else
                                {
                                    MessageBox.Show(username + " is " + finallocation,"Search Result");
                                }
                                
                            }
                        }
                        else
                        //If our location is != NULL then we're dealing with a POST request
                        {
                            int locationlength = location.Length;
                            sw.Write("POST /" + username + " HTTP/1.0\r\nContent-Length: " + locationlength + "\r\n\r\n" + location);
                            sw.Flush();
                            string response = sr.ReadLine();
                            //If we have the expected response, enter the statement
                            if (response.EndsWith("OK"))
                            {
                                if (consoleMode)
                                {
                                    //Show console message for non UI
                                    Console.Write(username + " location changed to be " + location,"Location Change");
                                }
                                else
                                {
                                    //Show messagebox for UI
                                    MessageBox.Show(username + " location changed to be " + location,"Location Change");
                                }
                                
                            }
                        }
                        break;
                    #endregion
                    #region 1.1
                    case "-h1":
                        if (location == null)
                        {
                            string connection = clientSetup.Connection;
                            //Send the correct request to the server
                            sw.Write("GET /?name=" + username + " HTTP/1.1\r\nHost: " + connection + "\r\n\r\n");
                            sw.Flush();
                            string firstreply = sr.ReadLine();
                            string response = null;
                            //Make sure that the first reply contains the correct response we need
                            if (firstreply.Contains("404"))
                            {
                                if (consoleMode)
                                {
                                    Console.Write("ERROR: no entries found");
                                }
                                else
                                {
                                    MessageBox.Show("ERROR: no entries found");
                                }
                                
                            }
                            else
                            {
                                //Append the readline to a string again
                                while (!sr.EndOfStream)
                                {
                                    response += sr.ReadLine() + " ";
                                }
                                //Split the string into useable chunks
                                string[] splitarray = response.Split((string[])null, 3, StringSplitOptions.RemoveEmptyEntries);
                                string finallocation = splitarray[2].Trim();
                                if (consoleMode)
                                {
                                    Console.Write(username + " is " + finallocation);
                                }
                                else
                                {
                                    MessageBox.Show(username + " is " + finallocation,"Search Result");
                                }
                                
                            }
                        }
                        else
                        {
                            //Pull in content we need to send the correct request
                            string connection = clientSetup.Connection;
                            //Create the strings we're going to send with the request
                            string contentappend = "name=" + username + "&location=" + location;
                            int contentlength = contentappend.Length;
                            sw.Write("POST / HTTP/1.1\r\nHost: " + connection + "\r\nContent-Length: " + contentlength + "\r\n\r\n" + "name=" + username + "&location=" + location);
                            sw.Flush();
                            string response = sr.ReadLine();
                            //Check if our response is what we expected it to be
                            if (response.EndsWith("OK"))
                            {
                                if (consoleMode)
                                {
                                    Console.Write(username + " location changed to be " + location);
                                }
                                else
                                {
                                    MessageBox.Show(username + " location changed to be " + location,"Location Change");
                                }
                                
                            }
                        }
                        break;
                        #endregion
                }
                #endregion
            }
            catch
            {
                //If an error occurs at any point and isn't handled by a seperate try catch loop then it goes here and outputs this error message
                Console.WriteLine("Error: Something went wrong");
            }


        }
    }
}
