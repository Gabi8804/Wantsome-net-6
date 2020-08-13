using System;
using System.Collections.Generic;
using System.Text;

namespace Week04
{
    class Curs
    {
        string nume;
        string anStudiu;
        Professor profesor;
        List<Student> studenti;

        public void PrintCurs()
        {

            Console.WriteLine($"Cursul cuprinde {nume} || {anStudiu}");
            profesor.PrintProfesor();
            foreach(var stud in studenti)
            {
                stud.PrintStudent();
            }
        }

        public Curs()
        {

        }
        public Curs(string nume,string anstudiu,Professor professor,List<Student> studenti)
        {
            this.nume = nume;
            this.anStudiu = anstudiu;
            this.profesor = professor;
            this.studenti = studenti;
        }

    }
}
