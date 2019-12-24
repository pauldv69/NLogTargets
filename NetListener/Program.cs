using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UDP;

namespace NetListener
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Receiving");
            UDPSocket s = new UDPSocket();
            s.Server("127.0.0.1", 5555);

            //UDPSocket c = new UDPSocket();
            //c.Client("127.0.0.1", 27000);
            //c.Send("TEST!");

            Console.ReadKey();
        }
    }
}
