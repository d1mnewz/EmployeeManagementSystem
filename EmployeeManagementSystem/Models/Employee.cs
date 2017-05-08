using System.Collections.Generic;

namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        public string FirstName { get; set; }


        public string LastName { get; set; }

        public int Salary { get; set; }

        public List<Skill> Skills { get; set; } = new List<Skill>();

        public int Id { get; set; }

        public string Position { get; set; }

        public Company Company { get; set; }
    }
}