using System;
using System.Collections.Generic;
using System.Text;

namespace Week04
{
    class Student
    {

        public string nume { get; set; }
        public string facultate { get; set; }
        public DateTime birthdate { get; set; }
        public int age
        {
            get
            {
                return (int)(DateTime.Now - birthdate).TotalDays / 365;
            }
            private set
            {
            }
        }

        public Student()
        {

        }

        public void PrintStudent()
        {
            Console.WriteLine($"Student is{nume} || {facultate} || {birthdate}|| {age}");
        }
        public Student(string nume, string facultate, DateTime birthdate)
        {
            this.nume = nume;
            this.facultate = facultate;
            this.birthdate = birthdate;

        }
    }
}
