namespace StudentsAndWorkers
{
    internal class Student : Human
    {
        public double grade;
        public Student(string firstName,string lastName,double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.grade = grade;
        }
    }
}