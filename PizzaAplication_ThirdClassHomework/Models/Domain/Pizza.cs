using PizzaAplication.Models.Enums;

namespace PizzaAplication.Models.Domain
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsOnPromotion { get; set; }
        public bool HasExtras { get; set; }
        public PizzaSize PizzaSize { get; set; }

        public bool PriceIsSet { get; set; }

    }
}
