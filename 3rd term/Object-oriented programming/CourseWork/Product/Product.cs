namespace CourseWork.Product
{
    public class Product
    {
        public string Name { get; }
        public float Price { get; set; }
        public string Description { get; set; }
        public int Amount { get; set;  }
        // purpose   
        // ID
        
        // public void 
        
        public Product(string name, float price, string description, int amount)
        {
            Name = name;
            Price = price;
            Description = description;
            Amount = amount;
        }

        public override string ToString()
        {
            return "Product " + Name + ", that costs " + Price + "$ - " + Description + " Only " + Amount + " left.";
        }
    }
}