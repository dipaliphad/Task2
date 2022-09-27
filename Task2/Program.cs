﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Program
    {
        public class Department
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Employee[] employees { get; set; }

        }
        public class Employee
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public double Salary { get; set; }
            public string Gender { get; set; }
        }
            
        static void Main(string[] args)
        {
            Employee[] emp1 = new Employee[]
            {
                new Employee{Name="Rahul",Age=25,Salary=40000,Gender="male"},
                new Employee{Name="Kajal", Age=26, Salary=45000,Gender="female"},
            };

            Employee[] emp2 = new Employee[]
            {
             new Employee{Name="sam",Age=26,Salary=50000,Gender="male"},
             new Employee{Name="Komal", Age=24, Salary=41000,Gender="female"},
             new Employee{Name="Arati", Age=23, Salary=35000,Gender="female"},
            };
            Employee[] emp3 = new Employee[]
            {
             new Employee{Name="Karan",Age=27,Salary=70000,Gender="male"},
            new Employee{Name="Kriya", Age=24, Salary=48000,Gender="female"},
            };

            Department[] departments = new Department[]
            {
             new Department{Id=1,Name="design",employees=emp1},
             new Department{Id=2,Name="quality",employees=emp2},
             new Department{Id=3,Name="purches",employees=emp3},
            };

            foreach(Department d in departments)
            {
                Console.WriteLine($"{d.Id} {d.Name}");
                foreach(Employee e in d.employees)
                {
                    Console.WriteLine($"\t{e.Name}->{e.Age}->{e.Salary}->{e.Gender}");
                }
            }
        }
    }
}
