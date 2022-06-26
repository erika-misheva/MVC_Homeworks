using Microsoft.AspNetCore.Mvc;
using PizzaAplication.Models.Domain;
using PizzaAplication.Models.Mapper;
using PizzaAplication.Models.ViewModels;


namespace PizzaAplication.Controllers
{
    public class OrderController : Controller
    {
        [Route("ListOrders")]
        public IActionResult ListOfOrders()
        {
            List<Order> dbOrders = StaticDb.Orders;
            //List<OrderJson> dbJsonOrders = StaticDb.JsonOrders;
            //return View(dbOrders);

            List<OrderDetailsViewModel> orderViewModels = StaticDb.Orders.Select(x => OrderMapper.ToOrderDetailsViewModel(x))
                .ToList();

            return View(orderViewModels);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }

            Order orderDb = StaticDb.Orders.FirstOrDefault(x => x.Id == id);
            if (orderDb == null)
            {
                return new EmptyResult();
            }

            OrderDetailsViewModel orderDetailsViewModel = OrderMapper.ToOrderDetailsViewModel(orderDb);

            //return View(orderDb);
            return View(orderDetailsViewModel);

        }

        public IActionResult JsonData()
        {
            return Json(StaticDb.JsonOrders);
        }

        public IActionResult RedirectToHome()
        {
            return RedirectToAction("Index","Home");
        }

    }

}
