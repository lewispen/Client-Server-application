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

namespace locationserver
{
    public class Logging
    {
        public static string LogFile = null;

        public Logging(string filename)
        {
            LogFile = filename;
        }

        private static readonly object locker = new object();

        public void WriteToLog(string host, string input, string status)
        {
            //My log formatting makes it so the log can output the correct content to the server console, otherwise the content may be incorrect
            #region log formatting
            string[] breakdown = input.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            if (breakdown.Length == 1)
            {
                //Changes formatting based on GET or POST
                if (breakdown[0].StartsWith("GET"))
                {
                    input = breakdown[0];
                }
                else
                {
                    string[] whoissplit = input.Split(new char[] { ' ' });
                    if (whoissplit.Length >= 2)
                    {
                        input = breakdown[0];
                    }
                    else
                    {
                        input = breakdown[0];
                    }
                }
            }
            else if (breakdown.Length >= 2)
            {
                //Changes formatting based on GET or POST
                if (breakdown[0].StartsWith("POST"))
                {
                    if (breakdown.Length >= 4)
                    {
                        input = breakdown[0] + " " +breakdown[1] + " " + breakdown[2] + " " + breakdown[3];
                    }
                    else
                    {
                        input = breakdown[0] + " " + breakdown[1] + " " + breakdown[2];
                    }
                    
                }
                else
                {
                    input = breakdown[0] + " " + breakdown[1];
                }
            }
            #endregion

            //Formats the line with the formatted variables
            String line = host + " - - " + DateTime.Now.ToString("'['dd'/'MM'/'yyyy':'HH':'mm':'s zz00']'") + " \"" + input + "\" " + status;
            lock (locker)
            {
                Console.WriteLine(line);
                if (LogFile == null)
                {
                    //If there isn't a log file then break out of the loop
                    return;
                }
                try
                {
                    StreamWriter sw;
                    sw = File.AppendText(LogFile);
                    sw.WriteLine(line);
                    sw.Close();
                }
                catch
                {
                    //If we can't write to the log file for whatever reason then output a response
                    Console.WriteLine("Unable to Write to Log File" + LogFile);
                }
            }
        }
    }
}
