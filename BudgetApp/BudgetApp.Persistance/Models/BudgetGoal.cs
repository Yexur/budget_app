using BudgetApp.Persistance.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace BudgetApp.Persistance.Models
{
    public class BudgetGoal : EntityBase
    {
        [DataMember]
        [Required]
        public double Cost { get; set; }

        [DataMember]
        public string Note { get; set; }

        [DataMember]
        [Required]
        public int User_Id { get; set; }

        [ForeignKey("User_Id")]
        public virtual User User { get; set; }
    }
}
