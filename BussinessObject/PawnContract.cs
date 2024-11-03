using System;
using System.ComponentModel.DataAnnotations;

namespace BussinessObject
{
    public class PawnContract
    {
        [Key]
        public int ContractId { get; set; }

        [Required]
        public int ItemId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Loan amount must be greater than 0.")]
        public decimal LoanAmount { get; set; }

        [DataType(DataType.Date)]
        public DateTime ContractDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime ExpirationDate { get; set; }
    }
}
