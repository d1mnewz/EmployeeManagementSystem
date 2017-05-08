using System.IO;
using EmployeeManagementSystem.Infrastructure.Config;
using Microsoft.AspNetCore.Hosting;
using StructureMap.AspNetCore;

namespace EmployeeManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .ConfigStructureMap()
                .UseStartup<Startup>()
                .UseApplicationInsights()
                .Build();

            host.Run();
        }
    }
}
