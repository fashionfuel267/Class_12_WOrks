using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Class_12_W04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Id=101,Name="Tanvir", JoiningDate="02-02-2010", Salary=50000});
            var emp2 = new Employee();
            emp2.Id = 102;
            emp2.Name = "Koyel";
            emp2.JoiningDate = "05-05-2011";
            emp2.Salary = 45000;
            employees.Add(emp2);

            employees.AddRange(new List<Employee> { 
            new Employee{Id=104,Name="momin", Salary=85000, JoiningDate="08-08-2010"},
            new Employee{Id=105,Name="Fahim", Salary=285000, JoiningDate="08-12-2010"},
            new Employee{Id=106,Name="Karim", Salary=185000, JoiningDate="08-11-2010"}
            });
            Console.WriteLine("Name\tSalary");
            foreach(var item in employees)
            {
                Console.WriteLine($"{item.Name}-----{item.Salary}" );
            }
            //Select Name,Salary from Tablename
            var result= from emp in employees
                        select emp;
            
            Console.ReadKey();
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public string Address { get; set; }
        //public string City { get; set; }
            
        //public string Region { get; set; }
        //public string DOB { get; set; }
        public string JoiningDate { get; set; }
        public double Salary { get; set;}

    }
}
