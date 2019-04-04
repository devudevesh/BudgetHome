using BudgetHome.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BudgetHome.ViewModels
{
    public class ExpenseViewModel
    {
        [Required]
        [StringLength(30)]
        public string Product { get; set; }

        [Required]
        public double PaidAmount { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public int PaymentModeId { get; set; }

        public IEnumerable<PaymentMode> PaymentModes { get; set; }

        [StringLength(50)]
        public string BankName { get; set; }

    }
}