using System;
using System.ComponentModel.DataAnnotations;

namespace BussinessObject
{
    public class ShopItem
    {
        [Key]
        public int ShopItemId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string Name { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string Description { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

        public bool IsExpired { get; set; }
    }
}
