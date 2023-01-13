using System;
using CourseWork.User;

namespace CourseWork
{
    public class LoginForm
    {
        UserService userService = new UserService();
        public void Login()
        {
            bool val = false;
            while (val != true)
            {
                val = RequestLogin();
            }
        }

        private void doRegistration()
        {
            Console.Write("Enter your registration name, please: ");
            userService.CreateUser(Console.ReadLine());
        }
        
        private bool RequestLogin()
        {
            Console.WriteLine("Enter you name, please:");
            var userName = Console.ReadLine();

            if (CheckUser(userName))
            {
                Console.WriteLine("Greetings, " + userName);
                return true;
            } 
            else
            {
                Console.WriteLine("Sorry, you have to register");
                Console.WriteLine("Re-directing you to the registration page");
                doRegistration();
                return false;
            }
        }

        private bool CheckUser(string login)
        {
            return userService.IsUser(login);
        }
    }
}