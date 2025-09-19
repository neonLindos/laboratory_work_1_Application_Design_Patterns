using lab1_adp.Controllers;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

EmployeeController ec = new EmployeeController();

var manager1 = ec.CreateManager("Анна Смирнова", 1, "Менеджер", 50000, 10000);
var manager2 = ec.CreateManager("Пётр Иванов", 2, "Менеджер", 60000, 15000);

var worker1 = ec.CreateWorker("Иван Петров", 3, "Рабочий", 500, 160);
var worker2 = ec.CreateWorker("Ольга Кузнецова", 4, "Рабочий", 600, 120);

Console.WriteLine("Расчёт зарплат сотрудников:\n");

Console.WriteLine($"{manager1.GetType().Name} {manager1.salaryCalculation()} тнг.");
Console.WriteLine($"{manager2.GetType().Name} {manager2.salaryCalculation()} тнг.");
Console.WriteLine($"{worker1.GetType().Name} {worker1.salaryCalculation()} тнг.");
Console.WriteLine($"{worker2.GetType().Name} {worker2.salaryCalculation()} тнг.");

Console.WriteLine("\nВсе сотрудники через контроллер:");
ec.ListEmployees();
