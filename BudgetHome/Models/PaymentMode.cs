using System.ComponentModel.DataAnnotations;

namespace BudgetHome.Models
{
    public class PaymentMode
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string ModeName { get; set; }
    }
}