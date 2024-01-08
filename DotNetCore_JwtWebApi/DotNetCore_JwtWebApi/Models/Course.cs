using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DotNetCore_JwtWebApi.Models
{
    public class Course
    {
            public Course()
            {
                Students = new List<Student>();
            }

            [Key]
            public int CourseID { get; set; }

            [Required]
            [NotNull]
            public string CourseName { get; set; }

            public virtual ICollection<Student> Students { get; }
        }
}
