using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymousmethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listemployees = new List<Employee>()
            {     new Employee { ID = 1, Name = "Siva" },
            new Employee { ID = 2, Name = "Karthikeya" }
            };
            //Predicate<Employee> EmployeePredicate = new Predicate<Employee>(FindEmployee);
            Employee employee = listemployees.Find(
                delegate (Employee emp)
                {
                    return emp.ID == 2;
                }
                );
            Console.WriteLine("Id is = {0}, Name is ={1}", employee.Name, employee.ID);
            Console.ReadKey();
        }

        //public static bool FindEmployee(Employee emp)
        //{
        //    return emp.ID == 2;
        //}
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
