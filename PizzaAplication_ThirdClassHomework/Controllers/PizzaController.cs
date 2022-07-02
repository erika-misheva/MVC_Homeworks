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
            if (id == null)
            {
                return RedirectToAction("Error");
            }
            Pizza pizza = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);
          
            if (pizza == null)
            {
                return new EmptyResult();
            }

            //return View(orderDb);
            PizzaViewModel pizzaViewModel = pizza.ToPizzaDetailsViewModel();

            return View(pizzaViewModel);

        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
