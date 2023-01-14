using System;
using CourseWork.Product;
using CourseWork.User;

namespace CourseWork.Purchase
{
    public class PurchaseAlgorithm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("________________________________________\n\n");
            Console.Write("Greetings, enter your name, please: ");
            var name = Console.ReadLine();
            CheckIfUserRegistered(name);
        }

        public static void temp()
        {
            var ps = new ProductService();   
            ps.CreateProduct("Flower pot", 17.99f, "Round ceramic flowerpot for your cosy house. Available in several sizes.",10);
            ps.CreateProduct("Bath towel", 6.99f, "Extra absorbent cotton towel, very wash resistant - will serve you for years.",3);
            ps.CreateProduct("Irregular shaper candle", 19.99f, "Candle with an irregular design. Burns up to 30 hours.",1);
            ps.CreateProduct("Wool stripped rug", 52.99f, "Rectangular wool rug in a combination of colours. A perfect for dull floor designs.",16);
            ps.CreateProduct("Bar hand soap", 12.99f, "Rectangular hand and body perfumed soap bar. It will hide all your naughties consequences",13);
            
            Console.WriteLine("________________________________________\n");
            var products = ps.GetAllProducts();
            
            products.ForEach(Console.WriteLine);
            
            ps.ChangeAmount("Flower pot", 18);
            var extraProduct = ps.FindProduct("Bath towel");
            ps.DeleteProduct(extraProduct.Name);
            ps.ChangePrice("Bar hand soap", 10.34f);
            ps.ChangeDescription("Wool stripped rug", "WHAT THE HELL BRUH??!");
            
            products = ps.GetAllProducts();
            Console.WriteLine("________________________________________\n");
            products.ForEach(Console.WriteLine);
        }
        
        public static void CheckIfUserRegistered(string name)
        {
            var userService = new UserService();
            userService.CreateUser("1");
            var exists = userService.UserExists(name);

            if (exists)
            {
                SuccessReg(userService.GetUser(name));
            }
            else
            {
                SuccessReg(userService.GetUser(name));
            }
        }

        public static void SuccessReg(User.User user)
        {
            Console.WriteLine("Greetings, " + user.UserName + "!");
            Console.WriteLine("Your current balance: " + user.Balance + "$.");
            Console.WriteLine("Enter what you want to do: \n - \"fill up the balance\" \n - \"shop\" \n - \"check the history\" \n - \"fill up the balance\" \n - \"exit\"");
            var action = Console.ReadLine();
            // add enum 
            CheckAction(user, action);
        }

        public static void CheckAction(User.User user, string action)
        {
            // if (action.EqualsIgnoreCase(""))
            if (action.Equals("exit"))
            {
                return;
            }

            if (action.Equals("fill up the balance"))
            {
                Balance(user);
            }

            if (action.Equals("check the history"))
            {
                // var userService = new UserService();
                // userService.CheckHistory();
                var purHist = user.Purchase;
                // Console.WriteLine(purHist.ForEach(.PurchaseItem + " price: " + ph.PurchasedValue + " | " + ph.Date)_;
                purHist.ForEach(Console.WriteLine);
            }

            if (action.Equals("shop"))
            {
                Shop(user);
            }
        }

        public static void Shop(User.User user)
        {
            var productService = new ProductService();
            var products = productService.GetAllProducts();
            products.ForEach(Console.WriteLine);
            Buy(user);
        }

        public static void Buy(User.User user)
        {
            var productService = new ProductService();
            var userService = new UserService();
            Console.WriteLine("Enter what would you like to buy");
            var toBuy = Console.ReadLine();
            var product = productService.FindProduct(toBuy);
            userService.DecreaseBalance(user.UserName, product.Price);
            var ph = new PurchaseHistory(product.Name, product.Price);
        }

        public static void Balance(User.User user)
        {
            var userService = new UserService();
            Console.WriteLine("Enter the sum you want to add");
            var value = Console.Read();

            if (value >= 1)
            {
                userService.IncreaseBalance(user.UserName, value);
            }
            else
            {
                throw new InvalidOperationException("Error! The input value can not be negative");
            }
        }
    }
}