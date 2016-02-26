using BudgetApp.Persistance.Core;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace BudgetApp.Persistance.Models
{
    public class User : EntityBase
    {
        private ICollection<LedgerItem> _ledgerItem;

        [DataMember]
        [Required]
        public string Name { get; set; }

        public virtual ICollection<LedgerItem> LedgerItem
        {
            get { return _ledgerItem ?? (new Collection<LedgerItem>()); }
            set { _ledgerItem = value; }
        }
    }
}
