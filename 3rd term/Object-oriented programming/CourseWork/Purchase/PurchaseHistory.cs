using System;

namespace CourseWork.Purchase
{
    public class PurchaseHistory
    {
        public string PurchasedItem { get; }
        public float PurchasedPrice { get; }
        public DateTime Date { get; }

        public PurchaseHistory(string purchasedItem, float purchasedPrice)
        {
            PurchasedItem = purchasedItem;
            PurchasedPrice = purchasedPrice;
            Date = DateTime.Now;
        }

        public override string ToString()
        {
            return PurchasedItem + " price: " + PurchasedPrice + " | " + Date;
        }
    }
}