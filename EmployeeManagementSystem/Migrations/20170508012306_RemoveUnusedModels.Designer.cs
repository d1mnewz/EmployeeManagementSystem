using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Migrations
{
    [DbContext(typeof(EmpManageContext))]
    [Migration("20170508012306_RemoveUnusedModels")]
    partial class RemoveUnusedModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeManagementSystem.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("EmployeeManagementSystem.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CompanyId");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Position");

                    b.Property<int>("Salary");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmployeeManagementSystem.Models.Employee", b =>
                {
                    b.HasOne("EmployeeManagementSystem.Models.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId");
                });
        }
    }
}
