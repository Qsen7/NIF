namespace Product_and_Sklad.Models
{
    public class Sklad
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public Sklad()
        {
            Products = new List<Product>();
        }
    }
}
