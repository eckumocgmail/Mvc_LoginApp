using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using Newtonsoft.Json;

using pickpoint_delivery_service;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Mvc_LoginApp
{
    public class MvcLoginAppProgram
    {
        [DllImport("User32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr h, string m, string c, int type);


        public void SearchProductConsole()
        {
            Console.Clear();
            using (var app = new AppDbContext())
            {
                Console.WriteLine(
                    JsonConvert.SerializeObject(

                        app.ProductsSearch(app.ProductInfos, 0, 100, 0, 10000)

                    )
                );
            }
        }
        public static void Main(string[] args)
        {









            Console.WriteLine(JsonConvert.SerializeObject(new AuthorizationOptions(),Formatting.Indented));
            try
            {

                var host = CreateHostBuilder(args).Build();
                host.Test();
                host.Run();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox((IntPtr)0, ex.Message, "Исключение", 0);
                MessageBox((IntPtr)0, ex.StackTrace, "Исключение", 0);

            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<MvcLoginAppStartup>();                    
                })
                .ConfigureServices(MvcLoginAppStartup.ConfigureMvcLoginAppBackgrounndServices);
    }
    public static class Extensions
    {
        public static IHost Test(this IHost builder)
        {

            Task.Run(() => {
                using (var scope = builder.Services.CreateScope())
                {

                    foreach (var context in scope.ServiceProvider.GetServices<AppDbContext>())
                    {
                        context.Database.EnsureDeleted();
                        context.Database.EnsureCreated();
                        Console.WriteLine(context.Database.CanConnect());
                        scope.ServiceProvider.GetService<IDeliveryDbContextInitiallizer>().Init(
                            scope.ServiceProvider.GetService<DeliveryDbContext>(),
                            System.IO.Directory.GetCurrentDirectory()
                        );

                        context.Log();
                    }
                    AuthDbInitiallizer.DoInitiallize();
                }
            });
            return builder;
        }
    }
}
