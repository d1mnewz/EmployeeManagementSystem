using Microsoft.EntityFrameworkCore;


namespace EmployeeManagementSystem.Models
{
    public class EmpManageContext : DbContext
    {
        public EmpManageContext(DbContextOptions<EmpManageContext> options)
            : base(options)
        {
            

           
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Project> Projects { get; set; }



    }
}