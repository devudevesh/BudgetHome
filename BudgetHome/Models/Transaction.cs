using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetHome.Models
{
    public class Transaction
    {
        public long Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Product { get; set; }

        [Required]
        public double PaidAmount { get; set; }
                
        public ApplicationUser User { get; set; }

        [Required]
        public string UserId { get; set; }

        public PaymentMode PaymentMode { get; set; }

        [Required]
        public int PaymentModeId { get; set; }

        [StringLength(50)]
        public string BankName { get; set; }

        [Required]
        [StringLength(6)]
        public string TransactionType { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }
    }
}