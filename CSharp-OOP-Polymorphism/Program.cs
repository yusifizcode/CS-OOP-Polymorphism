using System;
using ClassLibrary;
namespace CSharp_OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kitabin adini daxil edin: ");
            string bookName = Console.ReadLine();
            Console.WriteLine("Kitabin janrini daxil edin: ");
            string bookGenre = Console.ReadLine();
            Console.WriteLine("Kitabin muellifini daxil edin: ");
            string bookAuthor = Console.ReadLine();
            Console.WriteLine("Kitabin qiymetini daxil edin: ");
            double bookPrice = Convert.ToDouble(Console.ReadLine());
            
            Book book = new Book()
            {
                Name = bookName,
                Genre = bookGenre,
                Author = bookAuthor,
                Price = bookPrice
            };

            Console.WriteLine("Kitabin adini daxil edin: ");
            string book1Name = Console.ReadLine();
            Console.WriteLine("Kitabin janrini daxil edin: ");
            string book1Genre = Console.ReadLine();
            Console.WriteLine("Kitabin muellifini daxil edin: ");
            string book1Author = Console.ReadLine();
            Console.WriteLine("Kitabin qiymetini daxil edin: ");
            double book1Price = Convert.ToDouble(Console.ReadLine());

            Book book1 = new Book()
            {
                Name = book1Name,
                Genre = book1Genre,
                Author = book1Author,
                Price = book1Price
            };
            Library library = new Library();
            library.AddProduct(book);
            library.AddProduct(book1);
            //foreach (var item in library.Products)
            //{
            //    item.GetInfo();
            //}
            foreach (var item in library.GetProductsByPrice(10,50))
            {
                item.GetInfo();
            }
            foreach (var item in library.GetProductByName("o"))
            {
                item.GetInfo();
            }
        }
    }
}
