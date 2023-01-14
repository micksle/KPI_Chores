using System;

namespace CourseWork.Purchase
{
    public class PurchaseHistory
    {
        public string PurchasedItem { get; }
        public float PurchasedValue { get; }
        public DateTime Date { get; }

        public PurchaseHistory(string purchasedItem, float purchasedValue)
        {
            PurchasedItem = purchasedItem;
            PurchasedValue = purchasedValue;
            Date = DateTime.Now;
        }

        public override string ToString()
        {
            return PurchasedItem + " price: " + PurchasedValue + " | " + Date;
        }
    }
}