using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace ei8.Data.ExternalReference.Port.Adapter.Out.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls("http://+:80")
                .Build();
    }
}
