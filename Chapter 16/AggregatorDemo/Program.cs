﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace AggregatorDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls("https://[::]:44444")
                .UseStartup<Startup>();
    }
}