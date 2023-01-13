using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseWork.Product
{
    public class ProductService : IProductService
    {
        private DataBase dataBase;

        public ProductService()
        {
            dataBase = new DataBase();
        }

        public void CreateProduct(string productName, float price, string description, int amount)
        {
            var product = new Product(productName, price, description, amount);
            dataBase.Add(product);
            Console.WriteLine("Product " + productName + " created successfully");
        }

        public Product FindProduct(string productName)
        {
            var list = dataBase.Get();
            foreach (var p in list)
            {
                if (p.Name.Equals(productName))
                {
                    return p;
                }
            }

            return null;
            // return Guid.Empty;
        }

        public void DeleteProduct(string productName)
        {
            var list = dataBase.Get();
            // foreach (var p in list)
            // {
            //     if (p.Name.Equals(userName))
            //     {
            //         dataBase.Delete(p);
            //         Console.WriteLine("Product " + userName + " deleted successfully");
            //         return;
            //     }
            // }

            if (ProductExists(productName))
            {
                list.Remove(list.Find(x => x.Name == productName));
                Console.WriteLine("Product " + productName + " deleted successfully");
                return;
            }
            Console.WriteLine("Product " + productName + " was not found");
        }

        public bool ProductExists(string productName)
        {
            var list = dataBase.Get();
            foreach (var p in list)
            {
                if (p.Name.Equals(productName))
                {
                    return true;
                }
            }

            return false;
        }

        public List<Product> GetAllProducts()
        {
            var list = dataBase.Get();
            return list.Select(x => x).ToList();
        }

        public void ChangeAmount(string productName, int newAmount)
        {
            var product = FindProduct(productName);
            product.Amount = newAmount;
        }

        public void ChangeDescription(string productName, string newDescription)
        {
            var product = FindProduct(productName);
            product.Description = newDescription;
        }

        public void ChangePrice(string productName, float newPrice)
        {
            var product = FindProduct(productName);
            product.Price = newPrice;
        }
    }
}