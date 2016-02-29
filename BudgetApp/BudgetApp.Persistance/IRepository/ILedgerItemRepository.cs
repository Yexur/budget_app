using BudgetApp.Persistance.Core;
using BudgetApp.Persistance.Models;
using System.Linq;

namespace BudgetApp.Persistance.IRepository
{
    public interface ILedgerItemRepository : IRepository<LedgerItem>
    {
        IQueryable<LedgerItem> GetLedgerItemsByUserId(int userId);
    }
}
