using System;
using CourseWork.User;

namespace CourseWork.UI
{
    public class AuthorizationController : IControllerInterface
    {
        private DataBase.DataBase DB { get; }
        private UserService UserService { get; }

        public AuthorizationController(DataBase.DataBase dataBase)
        {
            DB = dataBase;
            UserService  = new UserService(DB);
        }

        public string PrintMessage()
        {
            return " - authorize user";
        }

        public void DoAction()
        {
            Console.WriteLine("Enter your username, please: ");
            var userName = Console.ReadLine();

            if (UserService.UserExists(userName))
            {
                Console.WriteLine("Greetings, " + userName);
            }
            else
            {
                Console.WriteLine("Sorry, you have to register");
                doRegistration();
            }
        }

        private void doRegistration()
        {
            Console.Write("Enter your registration name, please: ");
            var userName = Console.ReadLine();
            UserService.CreateUser(userName);  // todo check the name
        }
    }
}