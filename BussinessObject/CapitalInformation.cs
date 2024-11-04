using System.ComponentModel.DataAnnotations;

namespace BussinessObject
{
    public class CapitalInformation
    {
        [Key] 
        public int Id { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Total capital cannot be negative.")]
        public decimal TotalCapital { get; set; }  // Set to public for Entity Framework

        [Range(0, double.MaxValue, ErrorMessage = "Total income cannot be negative.")]
        public decimal TotalIncome { get; set; }  // Set to public for Entity Framework

        [Range(0, double.MaxValue, ErrorMessage = "Total expenditure cannot be negative.")]
        public decimal TotalExpenditure { get; set; }  // Set to public for Entity Framework

        public void UpdateCapital(decimal amount, bool isIncome)
        {
            if (isIncome)
            {
                TotalIncome += amount;
            }
            else
            {
                TotalExpenditure += amount;
            }
            TotalCapital = TotalIncome - TotalExpenditure;
        }
    }
}
