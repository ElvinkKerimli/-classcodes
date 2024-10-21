using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace ConsoleApp23
{
    internal class Library
    {
        Product[] products = { };

        public Library(string libraryName)
        {
            LibraryName = libraryName;
        }

        public string LibraryName { get; set; }
       
        public void AddProduct(Product product)
        {

            Array.Resize(ref products, products.Length + 1);
            products[^1] = product;

        }
        public Product[] GetProductsByPrice(double minPrice, double MaxPrice)
        {

            Product[] foundedBooks = { };

            foreach (var product in products)
            {
                if (product.Price > minPrice && product.Price < MaxPrice)
                {
                    Array.Resize(ref foundedBooks, foundedBooks.Length + 1);
                    foundedBooks[^1] = product;
                }
            }
            return foundedBooks;
        }
        public Product[] GetProductsByName(string name)
        {
            Product[] foundedBooks = { };

            foreach (var product in products)
            {
                if (product.Name == name)
                {
                    Array.Resize(ref foundedBooks, foundedBooks.Length + 1);
                    foundedBooks[^1] = product;
                }
            }
            return foundedBooks;

        }

    }
}
