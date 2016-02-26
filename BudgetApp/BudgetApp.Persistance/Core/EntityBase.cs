
using System.ComponentModel.DataAnnotations;

namespace BudgetApp.Persistance.Core
{
    public class EntityBase : IEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
