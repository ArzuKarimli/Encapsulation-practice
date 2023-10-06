using Services_Encapsulation_practice.Models;
using Services_Encapsulation_practice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services_Encapsulation_practice.Controller
{
    internal class BookController
    {
         private BookService bookService;

        public BookController()
        {
            bookService = new BookService();
        }

      

        public void GetAllByAuthor()
        {
            string authotName = "Nizami";
    
            Book[] result=bookService.GetByAuthor(authotName);

            foreach (Book book in result)
            {
                Console.WriteLine($"{book.Name}-{book.Author}");
            }
        }

        public void GetById()
        {
            int Id = 2;
      
            var result= bookService.GetById(Id);
            Console.WriteLine(result.Name+"-"+result.Author+"-"+result.PageCount);

        }
    }
}
