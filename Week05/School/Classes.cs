using System;
using System.Collections.Generic;

namespace School
{
    internal class Classes : Comment
    {
       
        public static List<string> uniqueIDs= new List<string>();
        public List<Student> students = new List<Student>();
        public List<Teacher> teachers = new List<Teacher>();

        public Classes(List<Student> student,List<Teacher> teacher,string uniqueID)
        {
            CheckUniqueIDs(uniqueID);
            this.students = student;
            this.teachers = teacher;
        }

        public Classes(List<Student> student, List<Teacher> teacher, string uniqueID,string comment)
        {
            CheckUniqueIDs(uniqueID);
            this.students = student;
            this.teachers = teacher;
            this.Comments = comment;
        }

        private void CheckUniqueIDs(string unique)
        {
            if (uniqueIDs.Contains(unique))
            {
                throw new ArgumentException("uniqueIDs", "A class with this unique id already exists.");
            }
            else
                uniqueIDs.Add(unique);
        }
    }
}