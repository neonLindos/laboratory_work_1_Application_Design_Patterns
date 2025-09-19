namespace lab1_adp.models
{
    public class Worker : Employee
    {
        private int hoursWorked;
        private double hourlyRate;

        public Worker(string name, int id, string jobTitle, double hourlyRate, int hoursWorked)
            : base(name, id, jobTitle, 0) 
        {
            this.hoursWorked = hoursWorked;
            this.hourlyRate = hourlyRate;
        }

        public override double salaryCalculation()
        {
            return hoursWorked * hourlyRate;
        }
    }
}
