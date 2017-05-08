using System.Collections.Generic;

namespace EmployeeManagementSystem.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public List<Employee> EmployeesInvolvedList { get; set; } = new List<Employee>();

        public string CustomerName { get; set; }
    }
}
