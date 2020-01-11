using System;
using System.Net;
using System.Threading.Tasks;
using CustomProtocolDemo.WebServices;

namespace CustomProtocolDemo
{
    public class Program
    {
        private static async Task Main(string[] args)
        {
            WebRequest.RegisterPrefix("dtrj", new RockWebRequestCreator());

            Console.WriteLine("Hello World!");
        }
    }
}