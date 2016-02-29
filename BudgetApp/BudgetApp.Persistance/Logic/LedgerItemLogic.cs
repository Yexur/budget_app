using BudgetApp.Persistance.IRepository;
using BudgetApp.Persistance.Models;
using System.Linq;

namespace BudgetApp.Persistance.Logic
{
    public class LedgerItemLogic : ILedgerItemLogic
    {
        private readonly ILedgerItemRepository _ledgerItemRpository;

        public LedgerItemLogic(ILedgerItemRepository ledgerItemRepository)
        {
            _ledgerItemRpository = ledgerItemRepository;
        }

        public LedgerItem Get(int id)
        {
            return _ledgerItemRpository.FindById(id);
        }

        public IQueryable<LedgerItem> GetList()
        {
            return _ledgerItemRpository.All();
        }

        public void Save(LedgerItem ledgerItem)
        {
            _ledgerItemRpository.Insert(ledgerItem);
        }

        public void Delete(int id)
        {
            _ledgerItemRpository.Delete(id);
        }

        public IQueryable<LedgerItem> GetLedgerItemsByUserId(int userId)
        {
            return _ledgerItemRpository.GetLedgerItemsByUserId(userId);
        }
    }
}
