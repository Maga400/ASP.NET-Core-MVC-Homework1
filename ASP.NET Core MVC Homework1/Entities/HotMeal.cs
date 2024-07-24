namespace ASP.NET_Core_MVC_Homework1.Entities
{
    public class HotMeal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public HotMeal()
        {

        }

        public HotMeal(int ıd, string name, string description, int price, int quantity)
        {
            Id = ıd;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Quantity = quantity;
        }
    }
}
