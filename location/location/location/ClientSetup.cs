using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace location
{
    class ClientSetup
    {
        //Below is all my getters and setters so i can retrieve content from this class and send them to the main class LocationClient.cs
        public string Connection { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Location { get; set; }
        public int Timeout { get; set; }
        public string Protocol { get; set; }

        public ClientSetup()
        {
            //This is the default clientsetup method that is run as soon as the program is started
            Connection = "whois.net.dcs.hull.ac.uk";
            Port = 43;
            Timeout = 1000;
            Protocol = "whois";
        }
        public void AdvancedSetup(string[] args)
        {
            try
            {
                //This class cycles through each of the arguements to check if there are any commands
                //contained within, it then checks and assigns the command variables
                for (int i = 0; i < args.Length; ++i)
                {
                    switch (args[i])
                    {
                        case "-h": Connection = args[++i]; break;
                        case "-p": Port = int.Parse(args[++i]); break;
                        case "-t": Timeout = int.Parse(args[++i]); break;
                        case "-h9": Protocol = args[i]; break;
                        case "-h0": Protocol = args[i]; break;
                        case "-h1": Protocol = args[i]; break;
                        case "whois": Protocol = args[i]; break;
                        default:
                            if (Username == null)
                            {
                                Username = args[i];
                            }
                            else if (Location == null)
                            {
                                Location = args[i];
                            }
                            else
                            {
                                Console.WriteLine("Too many args");
                            }
                            break;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error Unknown Arguement");
            }
        }
    }
}
