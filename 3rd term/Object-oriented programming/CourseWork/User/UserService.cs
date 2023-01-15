﻿using System;
using System.Collections.Generic;
using System.Linq;
using CourseWork.Purchase;

namespace CourseWork.User
{
    public class UserService : IUserService
    {
        private DataBase.DataBase DB { get; }

        public UserService(DataBase.DataBase dataBase)
        {
            DB = dataBase;
        }

        public void CreateUser(string userName, string password)
        {
            var user = new User(userName, password);
            DB.Users.Add(user);
            Console.WriteLine("User " + userName + " registered successfully");
        }

        public User GetUser(string userName)
        {
            if (UserExists(userName))
            {
                return DB.Users.Find(x => x.UserName.Equals(userName));
            }

            return new User("unknown", "qwertyui");
        }

        public bool CheckUsersPassword(string userName, string password)
        {
            var passwordService = new PasswordService(DB);
            var user = GetUser(userName);
            return passwordService.ComparePasswords(user, password);
        }

        public void DeleteUser(string userName)
        {
            if (UserExists(userName))
            {
                var user = GetUser(userName);
                DB.Users.Remove(user);
                Console.WriteLine("User " + userName + " deleted successfully");
                return;
            }

            Console.WriteLine("User " + userName + " was not found");
        }

        public bool UserExists(string userName)
        {
            foreach (var user in DB.Users)
            {
                if (user.UserName.Equals(userName))
                {
                    return true;
                }
            }

            return false;
        }

        public void PrintAllUsers()
        {
            if (DB.Users.Count == 0)
            {
                Console.WriteLine("The list of users is empty");
                return;
            }

            DB.Users.ForEach(Console.WriteLine);
        }

        public float GetBalance(User user)
        {
            if (UserExists(user.UserName))
            {
                return user.Balance;
            }
            
            return 0;
        }

        public void AddPurchase(User user, PurchaseHistory purchase)
        {
            if (UserExists(user.UserName))
            {
                user.Purchase.Add(purchase);
            }
        }

        public List<PurchaseHistory> GetHistory(User user)
        {
            if (UserExists(user.UserName))
            {
                return user.Purchase.ToList();   
            }

            return new List<PurchaseHistory>();
            // todo purchase wut 
            // todo check if null
        }

        public void IncreaseBalance(User user, float amount)
        {
            if (UserExists(user.UserName))
            {
                user.Balance += amount;
            }
            // todo if sum < 0
        }

        public void Action()
        {
            Console.WriteLine("What would you like to do: ");
            Console.WriteLine("show balance" +
                              "increase balance" +
                              "show purchase history");
        }
        
        public bool DecreaseBalance(User user, float price, int amount)
        {
            Console.WriteLine("price*amount: " + amount * price);
            if (price * amount >= user.Balance)
            {
                user.Balance -= price * amount;
                return true;
            }

            return false;
        }
    }
}