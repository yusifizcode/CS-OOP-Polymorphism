using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Book:Product
    {
        public string Author { get; set; }
        public string Genre { get; set; }


        public override void GetInfo()
        {
            Console.WriteLine($"Author: {Author} | Genre: {Genre} | Name: {Name} | Price: {Price}");
        }
    }
}
