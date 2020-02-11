using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string Cource { get; set; }
        public int Roll { get; set; }
        public string Photo { get; set; }
    }
}
