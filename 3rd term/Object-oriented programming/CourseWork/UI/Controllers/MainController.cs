using System;
using System.Collections.Generic;
using CourseWork.Product;

namespace CourseWork.UI
{
    public class MainController
    {
        private List<IControllerInterface> UIs { get; }

        public MainController()
        {
            var dataBase = new DataBase.DataBase();
            UIs = new List<IControllerInterface>(5);
            UIs.Add(new AuthorizationController(dataBase));
            UIs.Add(new ShowProductController(dataBase));
            UIs.Add(new AddProductController(dataBase));
            UIs.Add(new ExitController());
        }

        public void RunProgram()
        {
            try
            {
                while (true)
                {
                    ShowActions();
                    DoAction();
                }
            }
            catch (Exception)
            {
                throw new Exception("\n----Stopping the program----\n");
            }
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