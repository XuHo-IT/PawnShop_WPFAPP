using System;
using System.ComponentModel.DataAnnotations;

namespace BussinessObject
{
    public class ShopInformation
    {
        [Key] 
        public int Id { get; set; }

        [Required(ErrorMessage = "Shop Name is required.")]
        [StringLength(100, ErrorMessage = "Shop Name cannot exceed 100 characters.")]
        public string ShopName { get; set; }

        [Required(ErrorMessage = "Shop Address is required.")]
        [StringLength(200, ErrorMessage = "Shop Address cannot exceed 200 characters.")]
        public string ShopAddress { get; set; }

        [Phone(ErrorMessage = "Invalid phone number.")]
        public string Telephone { get; set; }
    }
}
