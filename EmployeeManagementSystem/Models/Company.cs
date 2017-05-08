using System.Collections.Generic;

namespace EmployeeManagementSystem.Models
{
    public class Company
    {
        public int Id { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();

        public string Title { get; set; }

        public List<Project> Projects { get; set; } = new List<Project>();
    }
}
