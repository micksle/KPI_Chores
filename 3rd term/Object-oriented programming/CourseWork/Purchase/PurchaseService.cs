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

        public void Buy(User.User user)
        {
            showInfo();
            Console.WriteLine("Enter what would you like to buy: ");
            var product = Console.ReadLine(); // todo asser safe input (length>0)
            if (checkProduct(product))
            {
                Console.WriteLine("Enter the amount you want to buy: ");
                var amount = int.Parse(Console.ReadLine());
                var success = BuyOperation(user, product, amount);
                if (success)
                {
                    var purchase = new PurchaseHistory(product, ProductService.GetProduct(product).Price);
                    UserService.AddPurchase(user, purchase);
                    Console.WriteLine("Product bought successfully");
                    return;
                }
                Console.WriteLine("Error, not enough items or amount of money");
            }

            Console.WriteLine("Incorrect product name!");
        }

        private bool BuyOperation(User.User user, string productName, int amount)
        {
            var product = ProductService.GetProduct(productName);
            if (ProductService.DecreaseAmount(productName, amount))
            {
                Console.WriteLine("price " + product.Price);
                if (UserService.DecreaseBalance(user, product.Price, product.Amount))
                {
                    return true;
                }
            }

            return false;
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