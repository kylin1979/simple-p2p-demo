using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using P2P;

namespace P2P
{
    static class ServerApp
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Server server = new Server();
            try
            {
                server.Start();
                Console.ReadLine();
                Console.ReadLine();
                server.Stop();
            }
            catch
            {
            }
        }
    }
}
