using System;

namespace School
{
    internal class Student : Comment, IPeople
    {
        private Guid uid = Guid.NewGuid();
        public Guid Uid { get => uid; set => uid = value; }
        public string Name { get ; set ; }

        public Student(string name)
        {
            this.Name = name;
            uid = Guid.NewGuid();
        }
        public Student(string name,string comment)
        {
            this.Name = name;
            uid = Guid.NewGuid();
            this.Comments = comment;
        }
    }
}