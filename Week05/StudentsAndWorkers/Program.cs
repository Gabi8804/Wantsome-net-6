using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsAndWorkers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
                {
                new Student("Gabriel", "Popa", 10),
                new Student("Cosmin", "Abalasei", 10),
                new Student("Diana", "Tanasa", 10),
                new Student("Ioana", "Moraru", 10),
                new Student("Carmina", "Simionescu", 10),
                new Student("Tatiana", "Popa", 10),
                new Student("Ilona", "Tanasa", 10),
                new Student("Ana", "Belciug", 10),
                new Student("Maria", "Nechita", 10),
                new Student("Andreea", "Ghinita", 10)
            };

            List<Worker> workers = new List<Worker>
                {
                 new Worker("Alin", "Popa", 8, 500),
                 new Worker("Gabriel", "Olariu", 8, 300),
                 new Worker("George", "Obreja", 8, 250),
                 new Worker("Eduard", "Cantemir", 8, 250),
                 new Worker("Ionut", "Popescu", 8, 140),
                 new Worker("Cezar", "Dumitrescu", 8, 350),
                 new Worker("Gheorghe", "Popa", 8, 500),
                 new Worker("Anastasia", "Badea", 8, 400),
                 new Worker("Anghel", "Hagi", 8, 1000),
                 new Worker("Tinca", "Vacarescu", 8, 800)
            };

            var sortedStudents = students.OrderBy(s => s.grade);
            var sortedWorkers = workers.OrderByDescending(w => w.MoneyPerHour());

            List<Human> mergedList = workers.Cast<Human>().Concat(students).OrderBy(h => h.FirstName).ThenBy(h => h.LastName).ToList();
        }   
    }
}
