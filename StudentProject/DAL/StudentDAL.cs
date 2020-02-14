using BOL;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

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
            Student data =(Student) context.Students.FirstOrDefault(x => x.Contact==contact);
            return data;
        }

        public Student GetStudentById(int Id)
        {
            return context.Students.Find(Id);
        }

        public Student GetStudentByRoll(int roll)
        {
            Student data = (Student)context.Students.FirstOrDefault(x => x.Roll==roll);
            return data;
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
