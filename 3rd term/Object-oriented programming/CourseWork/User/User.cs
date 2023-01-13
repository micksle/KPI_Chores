using System;
using System.Collections.Generic;

namespace CourseWork.User
{
    public class User
    {
        public string UserName { get; }
        public Guid Id { get; }
        public float Balance { get; set; }

        public User(string userName)
        {
            Id = Guid.NewGuid();
            UserName = userName;
            Balance = 0;
        }

        public override string ToString()
        {
            return "User`s name: " + UserName;
        }
    }
}