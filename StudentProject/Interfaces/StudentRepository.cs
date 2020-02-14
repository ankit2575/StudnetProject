using BOL;
using System.Collections.Generic;

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
