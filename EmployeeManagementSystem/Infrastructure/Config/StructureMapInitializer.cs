using Microsoft.AspNetCore.Hosting;
using StructureMap.AspNetCore;

namespace EmployeeManagementSystem.Infrastructure.Config
{
    public static class StructureMapInitializer
    {
        // do i need this to extend my application further? 
        // maybe i should just leave UseStructureMap in Program.cs?
        public static IWebHostBuilder ConfigStructureMap(this IWebHostBuilder builder) 
        {
            builder.UseStructureMap();
            return builder;
        }
    }
}