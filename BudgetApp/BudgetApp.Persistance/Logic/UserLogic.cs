using BudgetApp.Persistance.IRepository;
using BudgetApp.Persistance.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace BudgetApp.Persistance.Logic
{
    public class UserLogic : IUserLogic
    {
        private readonly IUserRepository _userRepository;
        private readonly ILedgerItemLogic _ledgerItemLogic;

        public UserLogic(IUserRepository userRepository, ILedgerItemLogic ledgerItemLogic)
        {
            _userRepository = userRepository;
            _ledgerItemLogic = ledgerItemLogic;
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

        public ICollection<SummaryView> LoadAllUsersSummary()
        {
            var allUsers = _userRepository.All();
            if (allUsers == null || !allUsers.Any())
            {
                return new Collection<SummaryView>();
            }
            return MapToSummaryView(allUsers);
        }

        private ICollection<SummaryView> MapToSummaryView(IQueryable<User> allUsers)
        {
            ICollection<SummaryView> summaryViews = new Collection<SummaryView>();
            foreach (var user in allUsers)
            {
                summaryViews.Add(new SummaryView
                {
                    UserId = user.Id,
                    Name = user.Name,
                    TotalBudget = SumOfLedgerItemsByUser(user.Id)
                });
            }
            return summaryViews;
        }

        private double SumOfLedgerItemsByUser(int userId)
        {
            var ledgerItems = _ledgerItemLogic.GetLedgerItemsByUserId(userId);
            if (ledgerItems == null || !ledgerItems.Any())
            {
                return 0;  //no items to sum
            }
            return ledgerItems.Sum(x => x.Amount);            
        }        
    }
}
