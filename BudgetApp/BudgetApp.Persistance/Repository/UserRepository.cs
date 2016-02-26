using BudgetApp.Persistance.Core;
using BudgetApp.Persistance.IRepository;
using BudgetApp.Persistance.Models;

namespace BudgetApp.Persistance.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(BudgetAppContext context) : base(context)
        {
        }
    }
}
