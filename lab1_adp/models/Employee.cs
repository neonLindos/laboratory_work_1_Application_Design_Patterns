namespace lab1_adp.models
{
    public abstract class Employee
    {
        protected string name;
        protected int id;
        protected string jobTitle;
        protected double baseSalary;

        public Employee(string name, int id, string jobTitle, double baseSalary)
        {
            this.name = name;
            this.id = id;
            this.jobTitle = jobTitle;
            this.baseSalary = baseSalary;
        }

        public abstract double salaryCalculation();
    }
}
