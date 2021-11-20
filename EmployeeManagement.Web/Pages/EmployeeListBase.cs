using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
        }

        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(3000);
            Employee e1 = new()
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Hastings",
                Email = "John@simtolwa.com",
                DateOfBirth = new(1980, 10, 5),
                Gender = Gender.Male,
                Department = new() { DepartmentId = 1, DepartmentName = "IT" },
                PhotoPath= "images/john.png"
            };

            Employee e2 = new()
            {
                EmployeeId = 2,
                FirstName = "Sam",
                LastName = "Galloway",
                Email = "Sam@simtolwa.com",
                DateOfBirth = new(1981,12,22),
                Gender = Gender.Male,
                Department = new() { DepartmentId = 2, DepartmentName = "HR"},
                PhotoPath = "images/sam.jpg"
            };

            Employee e3 = new()
            {
                EmployeeId = 4,
                FirstName = "Mary",
                LastName = "Smith",
                Email = "Mary@simtolwa.com",
                Gender = Gender.Female,
                DateOfBirth = new(1979,11,11),
                Department = new() { DepartmentId = 1, DepartmentName= "IT"},
                PhotoPath = "images/mary.png"
            };

            Employee e4 = new()
            {
                EmployeeId = 3,
                FirstName = "Sarah",
                LastName = "Longway",
                Email = "Sara@simtolwa.com",
                DateOfBirth = new(1982,9,23),
                Gender = Gender.Female,
                Department = new() { DepartmentId = 3, DepartmentName = "Payroll"},
                PhotoPath = "images/sara.png"
            };

            Employees = new List<Employee> { e1, e2, e3, e4 };
        }
    }
}
