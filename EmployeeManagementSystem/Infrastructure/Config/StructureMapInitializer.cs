using Microsoft.AspNetCore.Hosting;
using StructureMap.AspNetCore;

namespace EmployeeManagementSystem.Infrastructure.Config
{
    public static class StructureMapInitializer
    {
        public static IWebHostBuilder ConfigStructureMap(this IWebHostBuilder builder) // do i need this to extend my application further?
        {
            builder.UseStructureMap();
            return builder;
        }
    }
}