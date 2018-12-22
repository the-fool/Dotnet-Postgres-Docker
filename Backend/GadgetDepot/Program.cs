using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace GadgetDepot {
    public class Program {
        public static int Main(string[] args) {
            var host = CreateWebHostBuilder(args).Build();
            using(var scope = host.Services.CreateScope()) {
                var services = scope.ServiceProvider;

                var context = services.GetRequiredService<ApiDbContext>();
                var logger = services.GetRequiredService<ILogger<Program>>();

                try {
                    DbInitializer.Initialize(context);
                } catch (Exception ex) {
                    logger.LogError(ex, "An error occurred creating the DB.");
                }
            }

            host.Run();
            return 1;
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseUrls("http://0.0.0.0:5000")
            .UseStartup<Startup>();
    }
}