namespace PizzaAplication.Models.Domain
{
    public class OrderJson
    {
        public int OrderId { get; set; }
        public string Address { get; set; }
        public bool IsDelieverd { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
