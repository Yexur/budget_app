using BudgetApp.Persistance.Models;
using System.Collections.ObjectModel;
using System.Data.Entity.Migrations;


namespace BudgetApp.Persistance.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<BudgetAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BudgetAppContext context)
        {
            var userMike = new User
            {
                Name = "Mike",
                LedgerItem = new Collection<LedgerItem>()
                {
                    new LedgerItem()
                    {
                        Description = "First Item Mike",
                        Amount = 50.00,
                        Note = "Testing first item Mike"
                    },
                    new LedgerItem()
                    {
                        Description = "Second Item, Mike",
                        Amount = 60.00,
                        Note = "Testing first item, Mike"
                    }
                },
                BudgetGoal = new Collection<BudgetGoal>()
                {
                    new BudgetGoal()
                    {
                        Cost = 100.00,
                        Note = "First Budget Goal Mike"
                    },
                    new BudgetGoal()
                    {
                        Cost = 55.00,
                        Note = "Second Budget goal Mike"
                    }
                }
            };

            var userVal = new User
            {
                Name = "Val",
                LedgerItem = new Collection<LedgerItem>()
                {
                    new LedgerItem()
                    {
                        Description = "Val First Item",
                        Amount = 50.00,
                        Note = "Testing first item Val"
                    },
                    new LedgerItem()
                    {
                        Description = "Val Second Item",
                        Amount = 60.00,
                        Note = "Testing second item val"
                    }
                },
                BudgetGoal = new Collection<BudgetGoal>()
                {
                    new BudgetGoal()
                    {
                        Cost = 100.00,
                        Note = "First Budget Goal Val"
                    },
                    new BudgetGoal()
                    {
                        Cost = 55.00,
                        Note = "Second Budget goal Val"
                    }
                }
            };

            var userKairi= new User
            {
                Name = "Kairi",
                LedgerItem = new Collection<LedgerItem>()
                {
                    new LedgerItem()
                    {
                        Description = "Kairi First Item",
                        Amount = 50.00,
                        Note = "Testing first item Kairi"
                    },
                    new LedgerItem()
                    {
                        Description = "Kairi Second Item",
                        Amount = 60.00,
                        Note = "Testing second item Kairi"
                    }
                },
                BudgetGoal = new Collection<BudgetGoal>()
                {
                    new BudgetGoal()
                    {
                        Cost = 100.00,
                        Note = "First Budget Goal Kairi"
                    },
                    new BudgetGoal()
                    {
                        Cost = 55.00,
                        Note = "Second Budget goal Kairi"
                    }
                }
            };

            var userBree = new User
            {
                Name = "Bree",
                LedgerItem = new Collection<LedgerItem>()
                {
                    new LedgerItem()
                    {
                        Description = "Bree First Item",
                        Amount = 50.00,
                        Note = "Testing first item Bree"
                    },
                    new LedgerItem()
                    {
                        Description = "Bree Second Item",
                        Amount = 60.00,
                        Note = "Testing second item Bree"
                    }
                },
                BudgetGoal = new Collection<BudgetGoal>()
                {
                    new BudgetGoal()
                    {
                        Cost = 100.00,
                        Note = "First Budget Goal Bree"
                    },
                    new BudgetGoal()
                    {
                        Cost = 55.00,
                        Note = "Second Budget goal Bree"
                    }
                }
            };  

            context.Users.AddOrUpdate(userMike);
            context.Users.AddOrUpdate(userKairi);
            context.Users.AddOrUpdate(userBree);
            context.Users.AddOrUpdate(userVal);
        }
    }
}
