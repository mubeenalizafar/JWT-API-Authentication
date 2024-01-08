using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace DotNetCore_JwtWebApi.Models
{
    public class Address
    {
        [ForeignKey("Student")]
        public int AddressID { get; set; }

        [Required]
        [AllowNull]
        public string City { get; set; }

        [Required]
        [AllowNull]
        public string Country { get; set; }
        
        public virtual Student Student { get; set; }

    }
}
