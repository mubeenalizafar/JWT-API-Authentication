using DotNetCore_JwtWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_JwtWebApi.Repositery
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions option):base(option)
        {
            
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
