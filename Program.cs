using System;

namespace NTPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Host: ");
            var host = Console.ReadLine();
            Console.WriteLine(NTPClient.GetNetworkTime(host));
        }
    }
}
