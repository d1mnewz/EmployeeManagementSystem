using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Migrations
{
    [DbContext(typeof(EmpManageContext))]
    [Migration("20170504111903_InitialCreate")]
    partial class InitialCreate
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

                    b.Property<int?>("ProjectId");

                    b.Property<int>("Salary");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmployeeManagementSystem.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CompanyId");

                    b.Property<string>("CustomerName");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("EmployeeManagementSystem.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EmployeeId");

                    b.Property<int>("EstimateHoursToGain");

                    b.Property<string>("LongDescription");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("EmployeeManagementSystem.Models.Employee", b =>
                {
                    b.HasOne("EmployeeManagementSystem.Models.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId");

                    b.HasOne("EmployeeManagementSystem.Models.Project")
                        .WithMany("EmployeesInvolvedList")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("EmployeeManagementSystem.Models.Project", b =>
                {
                    b.HasOne("EmployeeManagementSystem.Models.Company")
                        .WithMany("Projects")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("EmployeeManagementSystem.Models.Skill", b =>
                {
                    b.HasOne("EmployeeManagementSystem.Models.Employee")
                        .WithMany("Skills")
                        .HasForeignKey("EmployeeId");
                });
        }
    }
}
