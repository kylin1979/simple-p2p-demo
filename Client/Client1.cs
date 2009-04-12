using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace P2P
{
    static class Client1
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Client client = new Client("119.137.89.227");
            client.ConnectToServer("leon1", "welcome");
            client.Start();
            Console.WriteLine("test arguments");
            while (true)
            {
                string str = Console.ReadLine();
                client.PaserCommand(str);
            }
        }
    }
}
