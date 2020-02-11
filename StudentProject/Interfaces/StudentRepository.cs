using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace Interfaces
{
    public interface StudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int Id);
        Student GetStudentByRoll(int Id);
        Student GetStudentByContact(string contact);
        bool Insert(Student student);
        bool Update(Student student);
        bool Delete(int Id);
    }
}
