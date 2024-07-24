namespace ASP.NET_Core_MVC_Homework1.Entities
{
    public class Drink
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public Drink()
        {

        }

        public Drink(int ıd, string name, string description, int price)
        {
            Id = ıd;
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }

    }
}
