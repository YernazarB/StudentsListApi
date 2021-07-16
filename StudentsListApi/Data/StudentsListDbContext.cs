using Microsoft.EntityFrameworkCore;
using StudentsListApi.Data.Entities;

namespace StudentsListApi.Data
{
    public class StudentsListDbContext : DbContext
    {
        public StudentsListDbContext(DbContextOptions<StudentsListDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}