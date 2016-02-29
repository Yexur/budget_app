using BudgetApp.Persistance.Models;
using System.Linq;

namespace BudgetApp.Persistance.Logic
{
    public interface ILedgerItemLogic
    {
        LedgerItem Get(int id);
        IQueryable<LedgerItem> GetList();
        void Save(LedgerItem ledgerItem);
        void Delete(int id);
        IQueryable<LedgerItem> GetLedgerItemsByUserId(int userId);
    }
}
