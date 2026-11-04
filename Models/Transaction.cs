using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace SmartBudgetTracker.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Du måste ange en beskrivning.")]
        public string Description { get; set; } = string.Empty;

        // Beloppet sparas med två decimaler
        [Required(ErrorMessage = "Du måste ange ett belopp.")]
        [Precision(18, 2)]
        [Range(0.01, 1000000000,
            ErrorMessage = "Beloppet måste vara större än 0 kr.")]
        public decimal Amount { get; set; }


        [Required(ErrorMessage = "Du måste välja en kategori.")]
        public string Category { get; set; } = string.Empty;

        [Required(ErrorMessage = "Du måste välja en typ.")]
        [RegularExpression("^(Income|Expense)$", ErrorMessage = "Du måste välja en giltig typ.")]
        public string Type { get; set; } = string.Empty;


        [DataType(DataType.Date)]
        public DateTime Date { get; set; } = DateTime.Today;
    }
}
