using System;
using EmployeeManagementSystem.Extensions;
using Faking;

namespace EmployeeManagementSystem.Models.Seeding
{
    public class CompaniesSeed : ISeed
    {
        private readonly EmpManageContext _context;

        public CompaniesSeed(EmpManageContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            _context.Companies.Clear();
            var rnd = new Random();

            for (int i = 0; i < rnd.Next(420); i++)
            {
                Company cmp = new Company
                {
                    Title = Faker.Default.Create<string>("lorem")
                };
                _context.Companies.Add(cmp);
            }
            _context.SaveChanges(true);  
        }
    }
}