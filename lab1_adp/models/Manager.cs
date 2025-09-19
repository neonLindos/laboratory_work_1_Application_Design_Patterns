namespace lab1_adp.models
{
    internal class Manager : Employee
    {
        private double bonus;

        public Manager(string name, int id, string jobTitle, double salary, double bonus)
            : base(name, id, jobTitle, salary)
        {
            this.bonus = bonus;
        }

        public override double salaryCalculation()
        {
            return baseSalary + bonus;
        }
    }
}
