using DietHolder2ClientWPF.Interfaces;
using Microsoft.Build.Framework;

namespace DietHolder2ClientWPF.Models
{
    public class Product : IProduct
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public decimal ProductPrice { get; set; }
        [Required]
        public double ProductCarboValue { get; set; }
        [Required]
        public double ProductProteinValue { get; set; }
        [Required]
        public double ProductFatValue { get; set; }
    }
}
