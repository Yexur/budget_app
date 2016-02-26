using BudgetApp.Persistance.Core;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace BudgetApp.Persistance.Models
{
    public class User : EntityBase
    {
        private ICollection<LedgerItem> _ledgerItem;
        private ICollection<BudgetGoal> _budgetGoal;

        [DataMember]
        [Required]
        public string Name { get; set; }

        public virtual ICollection<LedgerItem> LedgerItem
        {
            get { return _ledgerItem ?? (new Collection<LedgerItem>()); }
            set { _ledgerItem = value; }
        }

        public virtual ICollection<BudgetGoal> BudgetGoal
        {
            get { return _budgetGoal ?? (new Collection<BudgetGoal>()); }
            set { _budgetGoal = value; }
        }
    }
}
