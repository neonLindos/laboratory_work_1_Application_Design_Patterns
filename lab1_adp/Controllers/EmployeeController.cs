using System;
using System.Collections.Generic;
using lab1_adp.models;

namespace lab1_adp.Controllers
{
    public class EmployeeController
    {
        private List<Employee> employees;

        public EmployeeController()
        {
            employees = new List<Employee>();
        }

        // Добавление уже созданного сотрудника
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            Console.WriteLine($"Сотрудник {employee} добавлен в систему.");
        }

        // Альтернатива: создание нового сотрудника внутри метода (через параметры)
        public Employee CreateWorker(string name, int id, string jobTitle, double hourlyRate, int hoursWorked)
        {
            Employee worker = new Worker(name, id, jobTitle, hourlyRate, hoursWorked);
            employees.Add(worker);
            return worker;
        }

        public Employee CreateManager(string name, int id, string jobTitle, double baseSalary, double bonus)
        {
            Employee manager = new Manager(name, id, jobTitle, baseSalary, bonus);
            employees.Add(manager);
            return manager;
        }

        public double CalculateSalary(Employee employee)
        {
            return employee.salaryCalculation();
        }

        public void ListEmployees()
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp} → Зарплата: {emp.salaryCalculation()} тнг.");
            }
        }
    }
}
