using Services_Encapsulation_practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services_Encapsulation_practice.Services
{
    internal class BookService
    {
        public Book[] GetAll()
        {
            Book book1 = new()
            {
                Id = 1,
                Name = "Test1",
                Author = "Mushviq",
                PageCount = 200,
            };
            Book book2 = new()
            {
                Id = 2,
                Name = "Test2",
                Author = "Nizami",
                PageCount = 320,
            };
            Book book3 = new()
            {
                Id = 3,
                Name = "Test3",
                Author = "Cavid",
                PageCount = 330,
            };

            return new Book[] { book1, book2, book3 };
        }

        public Book[] GetByAuthor(string author)
        {
            Book[] books=GetAll();
            Book[] filteredBooks = books.Where(m => m.Author == author).ToArray();
            return filteredBooks;
        }
        public Book GetById(int Id)
        {
            Book[] books = GetAll();
            Book book=books.FirstOrDefault(m => m.Id == Id);
            return book;
        }
    }
}

