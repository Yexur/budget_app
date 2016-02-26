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
    }
}
