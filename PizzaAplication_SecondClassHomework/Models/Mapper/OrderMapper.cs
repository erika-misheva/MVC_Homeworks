using PizzaAplication.Models.Domain;
using PizzaAplication.Models.ViewModels;

namespace PizzaAplication.Models.Mapper
{
    public class OrderMapper
    {
        public static OrderDetailsViewModel ToOrderDetailsViewModel(Order orderDb)
        {
            return new OrderDetailsViewModel
            {
                PaymentMethod = orderDb.PaymentMethod,
                PizzaName = orderDb.Pizza.Name,
                Price = orderDb.Pizza.Price + 100.00,
                UserAddress = orderDb.User.Address,
                UserFullname = $"{orderDb.User.Name} {orderDb.User.LastName}"
            };
        }
    }
}
