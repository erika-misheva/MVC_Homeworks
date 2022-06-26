using PizzaAplication.Models.Domain;
using PizzaAplication.Models.ViewModels;

namespace PizzaAplication.Models.Mapper
{
    public class PizzaMapper
    {
        public static PizzaViewModel ToPizzaDetailsViewModel(Pizza pizzaDb)
        {
            return new PizzaViewModel
            {
                Id = pizzaDb.Id,
                Name = pizzaDb.Name,
                Price = SettingPrice(pizzaDb),
                PizzaSize = pizzaDb.PizzaSize
            };
        }
        public static double SettingPrice(Pizza pizzaDb)
        {
            if(pizzaDb.HasExtras == true)
            {
                return pizzaDb.Price = pizzaDb.Price + 10;
            }
            else
            {
                return pizzaDb.Price;
            }
        }
    }

}

