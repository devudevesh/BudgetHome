using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetHome.Models
{
    public class Transaction
    {
        public long Id { get; set; }

        [StringLength(30)]
        public string Product { get; set; }

        public double PaidAmount { get; set; }

        public ApplicationUser User { get; set; }

        public string UserId { get; set; }

        public PaymentMode PaymentMode { get; set; }

        public int PaymentModeId { get; set; }

        [StringLength(50)]
        public string BankName { get; set; }

        [StringLength(6)]
        public string TransactionType { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime TransactionDate { get; private set; }
    }
}