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
            UIs = new List<IControllerInterface>(8);
            UIs.Add(new AddProductController(dataBase));
            UIs.Add(new BuyProductController(dataBase, User));
            UIs.Add(new UserController(dataBase, User));
            UIs.Add(new ShowProductController(dataBase));
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
            Console.WriteLine("\n Enter what would you like to do (digit):");
            var option = Console.ReadLine();

            if (!string.IsNullOrEmpty(option))
            {
                var action = int.Parse(option);
                switch (action)
                {
                    case 1:
                        UIs[0].DoAction();
                        break;
                    case 2:
                        UIs[1].DoAction();
                        break;
                    case 3:
                        UIs[2].DoAction();
                        break;
                    case 4:
                        UIs[3].DoAction();
                        break;
                    case 5:
                        UIs[4].DoAction();
                        break;
                }
            }  // todo action massage equals enum == number from dict?
        }
    }
}