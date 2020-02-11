using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;

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
        public Student GetStudentByRoll(int id)
        {
            return objDb.GetStudentByRoll(id);
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
