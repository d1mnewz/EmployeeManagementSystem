using System;
using EmployeeManagementSystem.Models.Seeding;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagementSystem.Infrastructure.Config
{
    public static class AppDataSourceConfigurator
    {
        public static void InitializeDataSource(this IApplicationBuilder builder)
        {
            var seeders = builder.ApplicationServices.GetService<IServiceProvider>().GetServices<ISeed>();
            foreach (var seeder in seeders)
            {
                seeder.Seed();
            }
        }
    }
}