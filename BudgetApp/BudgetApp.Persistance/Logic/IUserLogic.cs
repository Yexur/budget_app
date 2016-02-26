using BudgetApp.Persistance.Models;
using System.Linq;

namespace BudgetApp.Persistance.Logic
{
    public interface IUserLogic
    {
        User Get(int id);
        IQueryable<User> GetList();
        void Save(User user);
        void Delete(int id);
    }
}
