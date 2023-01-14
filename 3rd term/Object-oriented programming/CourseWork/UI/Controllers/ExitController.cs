using System;

namespace CourseWork.UI
{
    public class ExitController : IControllerInterface
    {
        public string PrintMessage()
        {
            return " - stop the program";
        }

        public void DoAction()
        {
            throw new Exception("\n----Stopping the program----\n");
        }
    }
}