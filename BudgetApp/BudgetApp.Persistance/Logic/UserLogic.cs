using BudgetApp.Persistance.IRepository;
using BudgetApp.Persistance.Models;
using System.Linq;

namespace BudgetApp.Persistance.Logic
{
    public class UserLogic : IUserLogic
    {
        private readonly IUserRepository _userRepository;

        public UserLogic(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Get(int id)
        {
            return _userRepository.FindById(id);
        }

        public IQueryable<User> GetList()
        {
            return _userRepository.All();
        }

        public void Save(User user)
        {
            _userRepository.Insert(user);
        }

        public void Delete(int id)
        {
            _userRepository.Delete(id);
        }
    }
}
