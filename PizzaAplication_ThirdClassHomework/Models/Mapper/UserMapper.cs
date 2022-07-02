using PizzaAplication.Models.Domain;
using PizzaAplication.Models.ViewModels;

namespace PizzaAplication.Models.Mapper
{
    public static class UserMapper
    {
        public static UserViewModel ToUserViewModel(this User userDb)
        {
            return new UserViewModel
            {
                Name = userDb.Name,
                LastName = userDb.LastName
            };
        }

        public static List<UserViewModel> ToUserViewModels(this List<User> userDbs)
        {
            var userDbVMs = new List<UserViewModel>();

            foreach (var userDb in userDbs)
            {
                var userDbVM = ToUserViewModel(userDb);
                userDbVMs.Add(userDbVM);
            }

            return userDbVMs;
        }

    }
}
