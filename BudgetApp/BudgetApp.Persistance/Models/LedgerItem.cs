﻿using BudgetApp.Persistance.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace BudgetApp.Persistance.Models
{
    public class LedgerItem : EntityBase
    {
        [DataMember]
        [Required]
        public string Description { get; set; }

        [DataMember]
        [Required]
        public double Amount { get; set; }

        [DataMember]
        public string Note { get; set; }

        [DataMember]
        [Required]
        public int User_Id { get; set; }

        [ForeignKey("User_Id")]
        public virtual User User { get; set; }

    }
}
