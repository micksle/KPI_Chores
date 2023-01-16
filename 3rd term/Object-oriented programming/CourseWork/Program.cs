using System;
using CourseWork.UI;

/*
 * Запит імені користувача при вході
 * можливість поповнення балансу з головного меню (просто введенням числа і зарахуванням на рахунок)
 * можливість переглядання товарів і купівлі. при покупці гроші знімаються з рахунку і покупка додається в історію
 * реалізація корзини за бажанням
 */

namespace CourseWork
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        Console.WriteLine("________________________________________\n");
        
        var controller = new MainController();
        controller.RunProgram();
        }
    }
}