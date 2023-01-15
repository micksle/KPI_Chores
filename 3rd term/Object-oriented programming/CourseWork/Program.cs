using System;
using System.Collections.Generic;
using System.IO;
using CourseWork.DataBase;
using CourseWork.Product;
using CourseWork.UI;
using CourseWork.User;

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

        // var userService = new UserService();
        // userService.CreateUser("Mickle");
        // Console.WriteLine("contains user " + userService.IsUser("Mickle"));
        // // Guid user1_ID = userService.GetUser("Mickle");
        // // Console.WriteLine(user1_ID);
        // userService.GetAllUsers();
        // userService.DeleteUser("Mickle");
        // Console.WriteLine("contains user " + userService.IsUser("Mickle"));
        // userService.GetAllUsers();
        }
    }
}