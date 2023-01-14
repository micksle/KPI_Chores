using System;
using System.Collections.Generic;
using CourseWork.Purchase;

namespace CourseWork.User
{
    public class User
    {
        public string UserName { get; }
        public Guid Id { get; }
        public float Balance { get; set; }
        public List<PurchaseHistory> Purchase;

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