using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace DataAccessDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls("https://[::]:33333")
                .UseStartup<Startup>();
    }
}