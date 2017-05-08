using EmployeeManagementSystem.Models.Seeding;
using StructureMap;

namespace EmployeeManagementSystem.Infrastructure.IoC
{
    public class EfRegistry : Registry
    {
        public EfRegistry()
        {
            Scan(x =>
            {
                x.TheCallingAssembly();
                x.WithDefaultConventions();
                x.AddAllTypesOf<ISeed>();
            });
        }
    }
}
