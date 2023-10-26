using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9Home
{
    class Employee
    {
        // Защищенные поля, содержащие информацию о сотруднике.
        protected string name;
        protected int age;
        protected double salary;

        // Конструктор для инициализации полей.
        public Employee(string name, int age, double salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        // Виртуальный метод GetInfo для вывода информации о сотруднике.
        public virtual void GetInfo()
        {
            Console.WriteLine($"Имя: {name}, Возраст: {age}, Зарплата: {salary:C}");
        }

        // Виртуальный метод CalculateAnnualSalary для расчета годовой зарплаты сотрудника.
        public virtual double CalculateAnnualSalary()
        {
            return salary * 12;
        }
    }

}
