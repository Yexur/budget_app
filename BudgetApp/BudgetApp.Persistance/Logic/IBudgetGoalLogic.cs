using BudgetApp.Persistance.Models;
using System.Linq;

namespace BudgetApp.Persistance.Logic
{
    public interface IBudgetGoalLogic
    {
        BudgetGoal Get(int id);
        IQueryable<BudgetGoal> GetList();
        void Save(BudgetGoal user);
        void Delete(int id);
    }
}
