using BudgetApp.Persistance.IRepository;
using BudgetApp.Persistance.Models;
using System.Linq;
using System;

namespace BudgetApp.Persistance.Logic
{
    public class BudgetGoalLogic : IBudgetGoalLogic
    {
        private readonly IBudgetGoalRepository _budgetGoalRepository;

        public BudgetGoalLogic(IBudgetGoalRepository budgetGoalRepository)
        {
            _budgetGoalRepository = budgetGoalRepository;
        }

        public BudgetGoal Get(int id)
        {
            return _budgetGoalRepository.FindById(id);
        }

        public IQueryable<BudgetGoal> GetList()
        {
            return _budgetGoalRepository.All();
        }

        public void Save(BudgetGoal budgetGoal)
        {
            _budgetGoalRepository.Insert(budgetGoal);
        }

        public void Delete(int id)
        {
            _budgetGoalRepository.Delete(id);
        }
    }
}
