using Microsoft.AspNetCore.Hosting;
using static System.Console;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PG
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {

                CreateHostBuilder(args).Build().Run();
            }
            catch(Exception ex ) {
                WriteLine(ex);
            }
            finally
            {

            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
