using System;
using System.Collections.Generic;
using CourseWork.Product;
using CourseWork.User;

namespace CourseWork.Purchase
{
    public class PurchaseService
    {
        private DataBase.DataBase DB;
        private ProductService ProductService { get; }
        private UserService UserService { get; }

        public PurchaseService(DataBase.DataBase dataBase)
        {
            DB = dataBase;
            ProductService = new ProductService(dataBase);
            UserService = new UserService(dataBase);
        }

        public void Buy()
        {
            showInfo();
            Console.WriteLine("Enter what would you like to buy: ");
            var product = Console.ReadLine().ToLower(); // todo asser safe input (length>0)
            if (checkProduct(product.ToLower()))
            {
                Console.WriteLine("Enter the amount you want to buy: ");
                var amount = int.Parse(Console.ReadLine());
                BuyOperation(product, amount);
            }
        }

        private void BuyOperation(string productName, int amount)
        {
            var product = ProductService.GetProduct(productName);
            ProductService.DecreaseAmount(productName, amount);
            // UserService.DecreaseBalance(product.Price);
        }

        private void showInfo()
        {
            Console.WriteLine("Available products:");
            ProductService.ShowProducts();
        }

        private bool checkProduct(string productName)
        {
            var names = GetProductsName();
            foreach (var product in names)
            {
                if (product.Equals(productName))
                {
                    return true;
                }
            }

            return false;
        }

        private List<string> GetProductsName() // todo product service?
        {
            var products = ProductService.GetAllProducts();
            var productsName = new List<string>();
            foreach (var product in products)
            {
                productsName.Add(product.Name);
            }

            return productsName;
        }
    }
}