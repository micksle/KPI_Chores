﻿using System;

namespace CourseWork.User
{
    public class UserService : IUserInterface
    {
        private DataBase dataBase;

        public UserService()
        {
            dataBase = new DataBase();
        }

        public void CreateUser(string userName)
        {
            var user = new User(userName);
            dataBase.Add(user);
            Console.WriteLine("User " + userName + " created successfully");
        }

        public User GetUserByID(Guid id)
        {
            var list = dataBase.Get();
            if (list[0].Id.Equals(id))
            {
                return list[0];
            }

            return null;
        }
        public Guid GetUser(string userName)
        {
            var list = dataBase.Get();
            foreach (var u in list)
            {
                if (u.UserName.Equals(userName))
                {
                    return u.Id;
                }
            }
            return Guid.Empty;
        }

        public void DeleteUser(string userName)
        {
            var list = dataBase.Get();
            foreach (var u in list)
            {
                if (u.UserName.Equals(userName))
                {
                    dataBase.Delete(u);
                    Console.WriteLine("User " + userName + " deleted successfully");
                    return;
                }
            }

            Console.WriteLine("User " + userName + " was not found");
        }

        public bool IsUser(string userName)
        {
            var list = dataBase.Get();
            // Console.WriteLine(list[0].Id);
            foreach (var u in list)
            {
                if (u.UserName.Equals(userName))
                {
                    return true;
                }
            }

            return false;
        }

        public void GetAllUsers()
        {
            var list = dataBase.Get();
            if (list.Count == 0)
            {
                Console.WriteLine("The list of users is empty");
            }

            foreach (var u in list)
            {
                Console.WriteLine(u);
            }
        }
    }
}