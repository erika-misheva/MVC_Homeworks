using Microsoft.AspNetCore.Mvc;
using PizzaAplication.Models.Domain;


namespace PizzaAplication.Controllers
{
    public class OrderController : Controller
    {
        [Route("ListOrders")]
        public IActionResult ListOfOrders()
        {
            List<Order> dbOrders = StaticDb.Orders;
            List<OrderJson> dbJsonOrders = StaticDb.JsonOrders;
            return View(dbOrders);
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

            return View(orderDb);

        }

        public IActionResult JsonData()
        {
            return Json(StaticDb.JsonOrders);
        }

        public IActionResult Index()
        {
            return RedirectToAction("Index","Home");
        }

    }

}
