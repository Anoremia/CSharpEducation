using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task29
{
    public class Book
    {
        public static int BooksCount = 0;

        public string title;
        public string autor;
        public int year;
        public string genre;

        public Book(string title, string autor, int year, string genre)
        {
            this.title = title; 
            this.autor = autor;
            this.year = year;
            this.genre = genre;
            BooksCount++;
        }

    }
}
