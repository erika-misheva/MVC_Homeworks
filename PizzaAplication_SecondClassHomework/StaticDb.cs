using PizzaAplication.Models.Domain;
using PizzaAplication.Models.Enums;

namespace PizzaAplication
{
    public class StaticDb
    {
        public static List<Pizza> Pizzas = new List<Pizza> {
        new Pizza()
        {
            Id = 1,
            Name = "Vegetariana",
            Price = 400.00,
            IsOnPromotion = true,
            PizzaSize = PizzaSize.normal,
            HasExtras = false
        },
        new Pizza()
        {
            Id = 2,
            Name = "Margarita",
            Price = 300.00,
            IsOnPromotion = false,
            PizzaSize = PizzaSize.family,
            HasExtras = true,
    },
          new Pizza()
        {
            Id = 3,
            Name = "Quattro Formaggi",
            Price = 500.00,
            IsOnPromotion = false,
            PizzaSize = PizzaSize.family,
            HasExtras = true,
    }
    };

        public static List<User> Users = new List<User>
        {
            new User
            {
                Id = 1,
                Name = "Stefani",
                LastName= "Micevska",
                PhoneNumber = 078654765,
                Address = "ul Partizanski Odredi 101, 1000 Skopje"

            },
            new User
            {
                Id = 2,
                Name = "Bile",
                LastName= "Micevska",
                PhoneNumber = 078654745,
                Address = "ul Partizanski Odredi 101, 1000 Skopje"
            },
             new User
            {
                Id = 3,
                Name = "Eli",
                LastName= "Lazov",
                PhoneNumber = 078654745,
                Address = "ul Partizanski Odredi 101, 1000 Skopje"
            }

        };
        public static List<Order> Orders = new List<Order>
        {
            new Order
            {
                Id = 1,
                PizzaId = 1,
                UserId = 1,
                Pizza = Pizzas.First(x => x.Id == 1),
                User = Users.First(x => x.Id == 1),
                PaymentMethod = PaymentMethod.Cash
            },
            new Order
            {
                Id = 2,
                PizzaId = 2,
                UserId = 2,
                Pizza = Pizzas.First(x => x.Id == 2),
                User = Users.First(x => x.Id == 2),
                PaymentMethod = PaymentMethod.CreditCard
            },
            new Order
            {
                Id = 3,
                PizzaId = 3,
                UserId = 3,
                Pizza = Pizzas.First(x => x.Id == 3),
                User = Users.First(x => x.Id == 3),
                PaymentMethod = PaymentMethod.PayPal
            }
        };

        public static List<OrderJson> JsonOrders = new List<OrderJson>
        {
            new OrderJson
            {
                OrderId = 1,
                Address = "ul Partizanski Odredi 10b, Skopje 1000",
                IsDelieverd = true,
                OrderDate = new DateTime(2022,03,09)

            },
             new OrderJson
            {
                OrderId = 2,
                Address = "ul Partizanski Odredi 1a, Skopje 1000",
                IsDelieverd = false,
                OrderDate = new DateTime(2022,04,09)

            }
        };
    }
}
