using Microsoft.AspNetCore.Mvc;
using PizzaAplication.Models.Domain;
using PizzaAplication.Models.Mapper;
using PizzaAplication.Models.ViewModels;

namespace PizzaAplication.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult GetPizzas()
        {
            List<Pizza> pizzaDb = StaticDb.Pizzas;
            //return View(dbPizzas);
            List<PizzaViewModel> pizzaViewModels = pizzaDb.Select(x => PizzaMapper.ToPizzaDetailsViewModel(x))
               .ToList();

            //return View(ordersDb);
            return View(pizzaViewModels);
        }

        public IActionResult Details(int? id)
        {

            Pizza pizzaDb = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);
          
            if (pizzaDb == null)
            {
                return new EmptyResult();
            }

            //return View(orderDb);
            PizzaViewModel pizzaViewModels = PizzaMapper.ToPizzaDetailsViewModel(pizzaDb);
            return View(pizzaViewModels);

        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
