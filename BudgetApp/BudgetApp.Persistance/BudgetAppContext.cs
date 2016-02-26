
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
        /*public IDbSet<CategoryGroup> CategoryGroups { get; set; }
        public IDbSet<Category> Categories { get; set; }
        public IDbSet<ItemStatus> ItemStatus { get; set; }
        public IDbSet<Genre> Genres { get; set; }
        public IDbSet<TrackingCode> TrackingCodes { get; set; }
        public IDbSet<VideoGame> VideoGames { get; set; }
        public IDbSet<BoardGame> BoardGames { get; set; }*/


        //redendant now but we may use this in the future if we want to do something before or after we save changes to the database
        //public override int SaveChanges()
        //{
        //    return base.SaveChanges();
        //}
    }
}
