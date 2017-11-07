using System;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace aspnet_angular_sample
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
                // .UseConfiguration(new ConfigurationBuilder()
                //             .SetBasePath(Directory.GetCurrentDirectory())
                //             .AddJsonFile("hosting.json", optional:true)
                //             .Build())
                .Build();
    }
}
