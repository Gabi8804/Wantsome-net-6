namespace StudentsAndWorkers
{
    internal class Worker : Human
    {
        public int WorkHoursPerDay { get; set; }
        public double WeekSalary { get; set; }
        public Worker(string firstName, string lastName, int workHoursPerDay, double weekSalary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WorkHoursPerDay = workHoursPerDay;
            this.WeekSalary = weekSalary;
        }
        public double MoneyPerHour()
        {
            return WeekSalary / 5 / WorkHoursPerDay;
        }

    }
}