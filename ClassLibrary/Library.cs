using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Library
    {
        public Product[] Products = new Product[0];
        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length+1);
            Products[Products.Length-1] = product;
        }
        public Product[] GetProductsByPrice(int minPrice, int maxPrice)
        {
            Product[] filteredProducts = new Product[0];
            int j = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Price>minPrice && Products[i].Price<maxPrice)
                {
                    Array.Resize(ref filteredProducts, filteredProducts.Length+1);
                    filteredProducts[j] = Products[i];
                    j++;
                }
            }
            return filteredProducts;
        }
        public Product[] GetProductByName(string str)
        {
            Product[] filteredProducts = new Product[0];
            int j = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Name.Contains(str))
                {
                    Array.Resize(ref filteredProducts, filteredProducts.Length + 1);
                    filteredProducts[j] = Products[i];
                    j++;
                }
            }
            return filteredProducts;
        }
    }
}
