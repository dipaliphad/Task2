using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> employees = new List<Employee>();

    }
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public string Gender { get; set; }
    }
    public class program1
    {
        static void Main(string[] args)
        {
            List<Department> departmentList = new List<Department>()
            {
                new Department
                {
                    Id = 1,
                    Name = "design",
                    employees =
                    {
                        new Employee { Name = "sam", Age = 23, Salary = 30000, Gender = "male" },
                        new Employee { Name = "jaay", Age = 21, Salary = 20000, Gender = "male" },
                    }
                },
                new Department
                {
                    Id=2,
                    Name="quality",
                    employees =
                    {
                        new Employee { Name = "minal", Age = 22, Salary = 30000, Gender = "female" },
                        new Employee { Name = "ashwini", Age = 23, Salary = 34000, Gender = "female" },
                        new Employee { Name = "dipali", Age = 24, Salary = 33000, Gender = "female" },
                    }

                },
                new Department
                {
                    Id=3,
                    Name="purches",
                    employees=
                    {
                        new Employee { Name = "darshan", Age = 23, Salary = 30000, Gender = "male" },
                        new Employee { Name = "kajal", Age = 21, Salary = 20000, Gender = "female" },
                    }
                },
            };
            foreach (Department d in departmentList)
            {
                Console.WriteLine(d.Name);
                foreach (Employee e in d.employees)
                {
                    Console.WriteLine("\t" + e.Name + " " + e.Age + " " + e.Salary + " " + e.Gender);
                }
            }
            //    List<int> data = new List<int>();


            //    List<Employee> emp1 = new List<Employee>();
            //    {
            //        emp1.Add(new Employee { Name = "Rahul", Age = 25, Salary = 40000, Gender = "male" });
            //        emp1.Add(new Employee { Name = "Kajal", Age = 26, Salary = 45000, Gender = "female" });
            //    };

            //    List<Employee> emp2 = new List<Employee>();
            //    {
            //    emp2.Add(new Employee { Name = "sam", Age = 26, Salary = 50000, Gender = "male" });
            //    emp2.Add(new Employee { Name = "Komal", Age = 24, Salary = 41000, Gender = "female" });
            //    emp2.Add(new Employee { Name = "Arati", Age = 23, Salary = 35000, Gender = "female" });
            //    };
            //    List<Employee> emp3 = new List<Employee>
            //    {
            //     new Employee{Name="Karan",Age=27,Salary=70000,Gender="male"},
            //    new Employee{Name="Kriya", Age=24, Salary=48000,Gender="female"},
            //    };

            //    List<Department> departments = new List<Department>
            //    {
            //     new Department{Id=1,Name="design",employees=emp1},
            //     new Department{Id=2,Name="quality",employees=emp2},
            //     new Department{Id=3,Name="purches",employees=emp3},
            //    };

            //    foreach(Department d in departments)
            //    {
            //        Console.WriteLine($"{d.Id} {d.Name}");
            //        foreach(Employee e in d.employees)
            //        {
            //            Console.WriteLine($"\t{e.Name}->{e.Age}->{e.Salary}->{e.Gender}");
            //        }
            //    }
            //}

        }



    }
}
