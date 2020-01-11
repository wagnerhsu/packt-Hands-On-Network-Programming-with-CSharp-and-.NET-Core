﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace FitnessApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls(new string[] { "http://[::]:80", "https://[::]:443", "http://[::]:65432", "https://[::]:65431" })
                .UseStartup<Startup>();
    }
}