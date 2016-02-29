using System;
using System.Linq;
using BudgetApp.Persistance.Core;
using BudgetApp.Persistance.IRepository;
using BudgetApp.Persistance.Models;

namespace BudgetApp.Persistance.Repository
{
    public class LedgerItemRepository : Repository<LedgerItem> , ILedgerItemRepository
    {
        public LedgerItemRepository(BudgetAppContext context) : base(context)
        {
        }

        public IQueryable<LedgerItem> GetLedgerItemsByUserId(int userId)
        {
            return BudgetAppContext.LedgerItems.Where(v => v.User_Id == userId);
        }
    }
}
