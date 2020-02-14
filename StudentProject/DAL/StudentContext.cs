using BOL;
using System.Data.Entity;

namespace DAL
{
    public class StudentContext:DbContext
    {
        public StudentContext():base("StudentDB")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
