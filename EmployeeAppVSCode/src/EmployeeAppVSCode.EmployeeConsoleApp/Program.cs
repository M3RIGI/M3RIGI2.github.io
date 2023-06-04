// See https://aka.ms/new-console-template for more information
using EmployeeAppVSCode.EmployeeComponent;
using System.Collections.Generic;

namespace EmployeeAppVSCode.EmployeeConsoleApp
{

    class Program
    {

        static void Main (string[] args)
        {
            List<Employee> employees = new List<Employee> ();

            var employee = new Employee{
                ID = 1,
                FirstName = "John",
                LastName = "Doe",
                Gender = 'm'
                
            }; 

            employees.Add(employee);

            employee = new Employee {
                ID = 2,
                FirstName = "Bob",
                LastName = "Moe",
                Gender = 'm'
            };
            employees.Add(employee);

            employee = new Employee {
                ID = 3,
                FirstName = "Mary",
                LastName = "Jane",
                Gender = 'f'
            };

            employees.Add (employee);

            foreach(var emp in employees)
            {
                Console.WriteLine($"{emp.ID.ToString().PadRight(6)}{emp.FirstName.PadRight(15)}{emp.LastName.PadRight(15)}{emp.Gender.ToString().PadRight(20)}");
            }            
            }

                   }
  }

