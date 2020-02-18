using BOL;
using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class StudentBS
    {
        private StudentDAL objDb;
        public StudentBS()
        {
            objDb = new StudentDAL();
        }
        public IEnumerable<Student> GetAllStudents()
        {
            return objDb.GetAllStudents();
        }
        public Student GetStudentById(int id)
        {
            return objDb.GetStudentById(id);
        }
        public Student GetStudentByRoll(int roll)
        {
            return objDb.GetStudentByRoll(roll);
        }
        public Student GetStudentByContact(string contact)
        {
            return objDb.GetStudentByContact(contact);
        }
        public bool Insert(Student student)
        {
           return objDb.Insert(student);            
        }
        public bool Update(Student student)
        {
            return objDb.Update(student);
        }
        public bool Delete(int Id)
        {
            return objDb.Delete(Id);
        }
    }
}
