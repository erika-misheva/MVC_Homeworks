using PizzaAplication.Models.Domain;
using PizzaAplication.Models.ViewModels;

namespace PizzaAplication.Models.Mapper
{
    public static class PizzaMapper
    {
        public static PizzaViewModel ToPizzaDetailsViewModel(this Pizza pizzaDb)
        {
            return new PizzaViewModel
            {
                Id = pizzaDb.Id,
                Name = pizzaDb.Name,
                Price = SettingPrice(pizzaDb),
                PizzaSize = pizzaDb.PizzaSize,
                IsOnPromotion = pizzaDb.IsOnPromotion

                
               
            };
        }
        public static double SettingPrice(Pizza pizzaDb)
        {

            if(pizzaDb.HasExtras == true && pizzaDb.PriceIsSet == false )
            {
                pizzaDb.PriceIsSet = true;
                return pizzaDb.Price = pizzaDb.Price + 10;
            }
            else
            {
                return pizzaDb.Price;
            }
        }
    }

}

