using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BudgetHome.Models
{
    public class PaymentMode
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string ModeName { get; set; }
    }
}