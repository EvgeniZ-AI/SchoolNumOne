using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolNumOne
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext() :base("SchoolDbConnecting")
        {
        }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<assessment> assessments { get; set; }
    }
}
