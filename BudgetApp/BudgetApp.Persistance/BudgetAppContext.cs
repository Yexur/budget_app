
using BudgetApp.Persistance.Models;
using System.Data.Entity;

namespace BudgetApp.Persistance
{
    public class BudgetAppContext : DbContext
    {
        public BudgetAppContext()
            : base("name=BudgetAppContext")
        {
        }

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public IDbSet<User> Users { get; set; }
        public IDbSet<LedgerItem> LedgerItems { get; set; }
        public IDbSet<BudgetGoal> BudgetGoals { get; set; }
      
        //redendant now but we may use this in the future if we want to do something before or after we save changes to the database
        //public override int SaveChanges()
        //{
        //    return base.SaveChanges();
        //}
    }
}
