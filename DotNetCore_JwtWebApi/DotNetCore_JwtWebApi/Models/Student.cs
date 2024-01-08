using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DotNetCore_JwtWebApi.Models
{
    public class Student
    {
        public Student()
        {
            Courses = new List<Course>();
        }
        [Key]
        public int StudentID { get; set; }

        [Required]
        [NotNull]
        public string StudentName { get; set; }

        [Required]
        [NotNull]
        public string FatherName { get; set; }

        //1 to many relationship
        public Grade Grade { get; set; }

        //Many to many relationship
        public virtual ICollection<Course> Courses { get; set; }

        //1 to zero or 1 relationship
        public virtual Address Address { get; set; }
    }
}
