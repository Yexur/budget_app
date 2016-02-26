using BudgetApp.Persistance.Core;
using BudgetApp.Persistance.IRepository;
using BudgetApp.Persistance.Models;

namespace BudgetApp.Persistance.Repository
{
    public class BudgetGoalRepository : Repository<BudgetGoal>, IBudgetGoalRepository
    {
        public BudgetGoalRepository(BudgetAppContext context) : base(context)
        {
        }
    }
}
