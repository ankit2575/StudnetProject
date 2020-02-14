using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BOL
{
    [Table("StudentIdentity")]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string BlodGroup { get; set; }
        public string Contact { get; set; }
        public string Class { get; set; }
        public int Roll { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
        public string Session { get; set; }


    }
}
