using System;
using System.Collections.Generic;
using System.Text;

namespace Week04
{
    class Library

    {
        string address;
        DateTime openingHour;
        DateTime closingHour;
        List<Book> books;
        public Library()
        {
            this.address = "Iasi";
            this.openingHour = new DateTime(2020, 07, 28, 7, 0, 0);
            this.closingHour = new DateTime(2020, 07, 28, 18, 0, 0);
            this.books = new List<Book>();
        }
        public Library(string address, Book book)
        {
            this.address = address; ;
            this.openingHour = new DateTime(2020, 07, 28, 7, 0, 0);
            this.closingHour = new DateTime(2020, 07, 28, 18, 0, 0);
            //this.books = new List<Book>();
            //this.books.Add(book);
            this.books = new List<Book> { book };
        }
        public void PrintLibrary()
        {
            Console.WriteLine($"Title: {this.address}, address: {this.openingHour}, openingHour: {this.closingHour} , closingHour");
            books[0].PrintBook();
        }

    }
}
