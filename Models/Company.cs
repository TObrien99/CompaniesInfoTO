using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;

namespace CompaniesInfoTO.Models
{
    public class Company
    {
        public int Id { get; set; }
        [StringLength(90,MinimumLength = 3)]
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateFormed { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(8)]
        public int  Company_number { get; set; }
        [StringLength(150)]
        public string? Description { get; set; }
        [Required]
        public string? Address { get; set; }
    }
}
