using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using Interfaces;

namespace DAL
{
    public class StudentDAL : Context, StudentRepository
    {
        public bool Delete(int Id)
        {
            try
            {
                Student student = context.Students.Find(Id);
                context.Students.Remove(student);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return context.Students.ToList();
        }

        public Student GetStudentByContact(string contact)
        {
            return context.Students.Find(contact);
        }

        public Student GetStudentById(int Id)
        {
            return context.Students.Find(Id);
        }

        public Student GetStudentByRoll(int Id)
        {
            return context.Students.Find(Id);
        }

        public bool Insert(Student student)
        {
            try
            {
                context.Students.Add(student);
                context.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool Update(Student student)
        {
            try
            {
                context.Entry(student).State = EntityState.Modified;
                context.Configuration.ValidateOnSaveEnabled = false;
                context.SaveChanges();
                context.Configuration.ValidateOnSaveEnabled = true;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

}
