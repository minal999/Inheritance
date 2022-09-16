using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Demo.Employee;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Manager m1 = new Manager("managar1", 45000, 250, 5000);
            //m1.CalculateSalary();
            //Console.WriteLine(m1);

            //Employee e1 = new Manager("managar2", 43000, 250, 5000);
            //// association of method with object does at run time
            //e1.CalculateSalary(); // runtime polymorphism
            //Console.WriteLine(e1);

            //Employee e2 = new Employee("emp1", 34000, 200);
            //e2.CalculateSalary();
            //Console.WriteLine(e2);

            SalesManager sm1 = new SalesManager("jassi", 50000, 300, 200, 5000);
            sm1.CalculateSalary();
            Console.WriteLine(sm1);

        }
    }
}
