using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DotNetCore_JwtWebApi.Models
{
    public class Grade
    {
        public Grade()
        {
            Students = new List<Student>();
        }
        [Key]
        public int GradeID { get; set; }

        [Required]
        [NotNull]
        public string GradeName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
