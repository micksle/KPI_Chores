using System;
using System.Collections.Generic;

namespace CourseWork.UI
{
    public class MainController
    {
        private List<IControllerInterface> UIs { get; }
        private DataBase.DataBase dataBase { get; }
        
        private User.User User { get; set; }
        private bool auth;

        public MainController()
        {
            dataBase = new DataBase.DataBase();
            new DataBaseController(dataBase);
            auth = GotAuthorized(dataBase);
            UIs = new List<IControllerInterface>(5);
            UIs.Add(new ShowProductController(dataBase));
            UIs.Add(new UserController(dataBase, User));
            UIs.Add(new AddProductController(dataBase));
            UIs.Add(new BuyProductController(dataBase, User));
            UIs.Add(new ExitController(dataBase));
        }

        public void RunProgram()
        {
            // // throw new Exception("\n----Stopping the program----\n");
            // if (GotAuthorized(dataBase))
            if (auth)
            {
                while (true)
                {
                    ShowActions();
                    DoAction();
                }
            }
        }

        private bool GotAuthorized(DataBase.DataBase dataBase)
        {
            var auto = new AuthorizationController(dataBase);
            var access = false;
            while (access == false)
            {
                auto.DoAction();
                User = auto.GetUser();
                access = auto.GetState();
            }

            return true;
        }

        private void ShowActions()
        {
            Console.WriteLine("  Choose options:\n");
            foreach (var option in UIs)
            {
                Console.WriteLine(option.PrintMessage());
            }
        }

        private void DoAction()
        {
            Console.WriteLine("\n Enter what would you like to do:");
            var action = int.Parse(Console.ReadLine());
            UIs[action].DoAction();

            // todo action massage equals enum == number from dict?
        }
    }
}