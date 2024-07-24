namespace ASP.NET_Core_MVC_Homework1.Entities
{
    public class FastFood
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int CookingTime { get; set; }
        
        public FastFood()
        {

        }

        public FastFood(int ıd, string name, string description, int price, int cookingTime)
        {
            Id = ıd;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.CookingTime = cookingTime;
        }
    }
}
