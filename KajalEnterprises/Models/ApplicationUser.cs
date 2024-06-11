using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace KajalEnterprises.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public int Name { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PinCode { get; set; }
    }
}
