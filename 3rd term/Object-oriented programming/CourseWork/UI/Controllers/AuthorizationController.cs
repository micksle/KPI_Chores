using System;
using CourseWork.User;

namespace CourseWork.UI
{
    public class AuthorizationController : IControllerInterface
    {
        private DataBase.DataBase DB { get; }
        private UserService UserService { get; }
        private User.User User { get; set; }
        private bool Authorized { get; set; }

        public AuthorizationController(DataBase.DataBase dataBase)
        {
            DB = dataBase;
            UserService = new UserService(DB);
        }

        public string PrintMessage()
        {
            return "Log in into your account, please";
        }

        public void DoAction()
        {
            Console.WriteLine("Enter your username, please: ");
            var userName = Console.ReadLine();

            if (UserService.UserExists(userName))
            {
                var isChecked = false;
                while (isChecked == false)
                {
                    Console.WriteLine("Enter your password, please: ");
                    var password = Console.ReadLine();
                    isChecked = UserService.CheckUsersPassword(userName, password);
                }

                User = UserService.GetUser(userName);
                Console.WriteLine("Greetings, " + userName);
                Authorized = true;
            }
            else
            {
                Console.WriteLine("Sorry, you have to register, redirect you? (Y/N)");
                var agreement = Console.ReadLine().ToLower().Equals("y");
                if (agreement)
                {
                    doRegistration();
                }
            }
        }

        public bool GetState()
        {
            return Authorized;
        }

        public User.User GetUser()
        {
            return User;
        }

        private void doRegistration()
        {
            Console.Write("Enter your registration name, please: ");
            var userName = Console.ReadLine();
            Console.Write("Enter your password: ");
            var password = Console.ReadLine();
            UserService.CreateUser(userName, password); // todo check the name
        }
    }
}