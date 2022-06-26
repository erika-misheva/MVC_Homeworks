using PizzaAplication.Models.Enums;

namespace PizzaAplication.Models.ViewModels
{
    public class OrderDetailsViewModel
    {
       public string PizzaName { get; set; }
        public string UserFullname { get; set; }
        public double Price { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string UserAddress { get; set; }
    }
}
