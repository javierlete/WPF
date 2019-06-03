using System.Collections.Generic;
using System.Data.Entity;

namespace EntityFramework1
{
    public class SchoolContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
