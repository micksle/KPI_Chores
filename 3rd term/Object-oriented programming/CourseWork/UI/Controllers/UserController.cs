using System;
using CourseWork.User;

namespace CourseWork.UI
{
    public class UserController: IControllerInterface
    {
        private DataBase.DataBase DB { get; }
        private User.User User { get; }

        public UserController(DataBase.DataBase dataBase, User.User user)
        {
            DB = dataBase;
            User = user;
        }

        public string PrintMessage()
        {
            return " - show personal info";
        }

        public void DoAction()
        {
            Action();
        }

        private bool Action()
        {
            var us = new UserService(DB);
            var exit = false;
            while (exit == false)
            {
                Console.WriteLine(" - show balance");
                Console.WriteLine(" - increase balance");
                Console.WriteLine(" - view purchase history");
                Console.WriteLine(" - exit");
                Console.WriteLine("Enter what would you like to do:");
                var choice = Console.ReadLine();

                if (choice.ToLower().Equals("show balance"))
                {
                    Console.WriteLine("Your balance: " + us.GetBalance(User) + "$.");
                }
                if (choice.ToLower().Equals("increase balance"))
                {
                    Console.WriteLine("enter the amount:");
                    var value = int.Parse(Console.ReadLine());
                    if (value >= 0)
                    {
                        us.IncreaseBalance(User, value);
                        Console.WriteLine("Your balance: " + us.GetBalance(User) + "$.");
                    }
                    else
                    {
                        Console.WriteLine("Error, sum is incorrect");
                    }
                }
                if (choice.ToLower().Equals("view purchase history"))
                {
                    var purchases = us.GetHistory(User);
                    if (purchases.Count == 0)
                    {
                        Console.WriteLine("You haven`t done any purchases yet");
                    }
                    else
                    {
                        purchases.ForEach(Console.WriteLine);
                    }
                }
                if (choice.ToLower().Equals("exit"))
                {
                    exit = true;
                }
            }

            return true;
        }
    }
}