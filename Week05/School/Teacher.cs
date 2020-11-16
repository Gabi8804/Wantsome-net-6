using System.Collections.Generic;

namespace School
{
    internal class Teacher: Comment,IPeople
    {
        public List<Discipline> Disciplines = new List<Discipline>();
        public string Name { get; set; }

        public Teacher(List<Discipline> disciplines,string name,string comment)
        {
            this.Disciplines = disciplines;
            this.Name = name;
            this.Comments = comment;
        }
        public Teacher(List<Discipline> disciplines, string name)
        {
            this.Disciplines = disciplines;
            this.Name = name;
        }
    }
}