using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9Home
{
    class Manager : Employee
    {
        private double bonus;

        // Конструктор класса Manager для инициализации полей базового класса и поля bonus.
        public Manager(string name, int age, double salary, double bonus)
            : base(name, age, salary)
        {
            this.bonus = bonus;
        }

        // Переопределение метода GetInfo для вывода информации о менеджере, включая бонус.
        public override void GetInfo()
        {
            base.GetInfo(); // Вызов метода базового класса для вывода общей информации.
            Console.WriteLine($"Премия: {bonus:C}");
        }

        // Переопределение метода CalculateAnnualSalary для расчета годовой зарплаты менеджера.
        public override double CalculateAnnualSalary()
        {
            return (salary + bonus) * 12;
        }


    }
}
