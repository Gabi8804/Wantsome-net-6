using System;
using System.Collections.Generic;

namespace Week04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Author arghezi = new Author();
            //Author creanga = new Author("Creanga", "creanga@gmail.com", 2);
            //arghezi.printAuthor();
            //creanga.printAuthor();
            //Book b1 = new Book();
            //b1.PrintBook();
            //Console.WriteLine("========================================================================================================================================================");
            //Book b2 = new Book("Dama cu Camelii", 1864, 19.99);
            //b2.PrintBook();
            //Console.WriteLine("========================================================================================================================================================");
            //Book b3 = new Book("Amintiri din copilarie", creanga, 1834, 99.99);
            //b3.PrintBook();
            //Console.WriteLine("========================================================================================================================================================");
            //Book b4 = new Book("Morometii", "Marin Preda", "marin.preda@gmail.com", 7, 1934, 29.99);
            //b4.PrintBook();
            //Console.WriteLine("========================================================================================================================================================");

            //Book b5 = new Book("IT", 1995, 19.99);
            //Library l = new Library();
            //Library l2 = new Library("Iasi2", b5);
            //l2.PrintLibrary();

            //Professor p1 = new Professor();
            //Professor p2 = new Professor("Ionescu", "FEAA", "AgroEconomie");
            //Professor.PrintNrProfesori();



            Student a = new Student();
            a.birthdate = new DateTime(1998, 12, 20);
            a.facultate = "Asachi";
            a.nume = "Popescu";
            a.PrintStudent();


            Professor prof = new Professor("Ionescu", "Automatica", "Asachi");

            Student stud = new Student("Popescu","UBB",new DateTime(1990,5,16));
            List<Student> student = new List<Student> { stud, a };
            Curs Info = new Curs("Info", "2020", prof, student);
            Info.PrintCurs();
        }
    }
}
