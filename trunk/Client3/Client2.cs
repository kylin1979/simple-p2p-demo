using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using P2P;

namespace P2P
{
    class Client2
    {
        static void Main(string[] args)
        {
            Client client = new Client("119.137.89.227");
            client.ConnectToServer("leon3", "welcome");
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
