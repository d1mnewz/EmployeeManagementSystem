using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeManagementSystem.Extensions;
using Faking;

namespace EmployeeManagementSystem.Models.Seeding
{
    public class EmployeeSeed : ISeed
    {
        private readonly EmpManageContext _context;

        public EmployeeSeed(EmpManageContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            _context.Employees.Clear();
            var rnd = new Random();
            var employees = new List<Employee>();

            for (int i = 0; i < rnd.Next(420); i++)
            {
                var emp = new Employee
                {
                    Company = _context.Companies.ToArray().RandomElement(),
                    FirstName = Constants.Firstnames.RandomElement(),
                    LastName = Constants.Lastnames.RandomElement(),
                    Position = Faker.Default.Create<string>("job"),
                    Salary = Faker.Default.Create<int>()
                };
                employees.Add(emp);
            }
            _context.AddRange(employees);
            _context.SaveChanges(true);

        }
    }
}