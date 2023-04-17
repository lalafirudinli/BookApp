
using BookApp.App.Services.Interfaces;
using BookApp.Core.Models;

namespace BookApp.App.Services.Implementations
{
    public class BookService : IBookService
    {
        public Book [] Books = {};

   
        public void Createbook()
        {
            Book book = new Book();

            Console.WriteLine("Add Name");
            book.Name = Console.ReadLine();

            Console.WriteLine("Add Price");
            book.Price = Double.Parse(Console.ReadLine());

            Array.Resize(ref Books, Books.Length + 1);

            Books[Books.Length - 1] = book;

        }

        public void GetFullInfo()
        {
            if (Books.Length == 0)
            {
                Console.WriteLine("Book no included");
            }

            foreach (Book book in Books)
            {
                Console.WriteLine($"Name {book.Name} Price {book.Price}");
            }
        }
    }
}
