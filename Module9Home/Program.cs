using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9Home
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Саша", 35, 60000, 5000);
            Developer developer = new Developer("Оля", 28, 70000, 50);

            Console.WriteLine("Информация о менеджере:");
            manager.GetInfo();
            Console.WriteLine($"Годовая зарплата менеджера: {manager.CalculateAnnualSalary():C}");

            Console.WriteLine("\n Информация о разработчике:");
            developer.GetInfo();
            Console.WriteLine($"Годовая зарплата разработчика: {developer.CalculateAnnualSalary():C}");
        }
    }
}
