using System;
using System.Collections.Generic;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Gica");
            var discipline = new Discipline("Info", 2, 70);
            var disciplineList = new List<Discipline> { discipline };
            var teacher = new Teacher(disciplineList, "Popa");

            var teacherList = new List<Teacher> { teacher };
            var studentList = new List<Student> { student };

            var class1 = new Classes(studentList, teacherList, "12C");
            var class2 = new Classes(studentList, teacherList, "12C");

            Console.WriteLine(Classes.uniqueIDs.Count);
        }


    }
}
