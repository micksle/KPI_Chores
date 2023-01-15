using System;
using System.Collections.Generic;
using CourseWork.User;

namespace CourseWork.UI
{
    public class MainController
    {
        private List<IControllerInterface> UIs { get; }
        private DataBase.DataBase dataBase { get; }

        public MainController()
        {
            dataBase = new DataBase.DataBase();
            new DataBaseController(dataBase);
            UIs = new List<IControllerInterface>(5);
            UIs.Add(new ShowProductController(dataBase));
            UIs.Add(new AddProductController(dataBase));
            UIs.Add(new BuyProductController(dataBase));
            UIs.Add(new ExitController());
        }

        public void RunProgram()
        {
            // // throw new Exception("\n----Stopping the program----\n");
            if (GotAuthorized(dataBase))
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