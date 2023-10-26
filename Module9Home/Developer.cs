using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9Home
{
    class Developer : Employee
    {
        private int linesOfCodePerDay;

        public Developer(string name, int age, double salary, int linesOfCodePerDay)
            : base(name, age, salary)
        {
            this.linesOfCodePerDay = linesOfCodePerDay;
        }

        // Переопределение метода GetInfo для вывода информации о разработчике.
        public override void GetInfo()
        {
            base.GetInfo(); // Вызываем метод базового класса для вывода общей информации.
            Console.WriteLine($"Lines of Code Per Day: {linesOfCodePerDay}");
        }

        // Переопределение метода CalculateAnnualSalary для расчета годовой зарплаты разработчика.
        public override double CalculateAnnualSalary()
        {
            double additionalPayment = linesOfCodePerDay * 10 * 20; // Предполагаем 10 строк кода в час и 20 рабочих дней в месяц.
            return (salary + additionalPayment) * 12;
        }
    }
}

