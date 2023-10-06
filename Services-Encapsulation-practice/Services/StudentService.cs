using Services_Encapsulation_practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Services_Encapsulation_practice.Services
{


   

    internal class StudentService
    {
      

          private Student[] GetAll()
        {
            
            Student student1 = new()
            {
                Id = 1,
                Name = "Ilham",
                SurName = "Abasli",
                Birthday = new(2001, 02, 05)
            };
            Student student2= new()
            {
                Id = 2,
                Name = "Metanet",
                SurName = "Abbasova",
                Birthday = new(1999,12,01),
            };
            Student student3= new()
            {
                Id = 3,
                Name = "Meryem",
                SurName = "Elizade",
                Birthday = new(1997, 02, 12)
            };
            Student student4 = new()
            {
                Id = 4,
                Name = "Feride",
                SurName = "Abishova",
                Birthday = new(1992, 07, 07)
           
            };

            return new Student[] { student1, student2, student3, student4 };
        }

        public Student[] GetAllStudents( DateTime startDate, DateTime endDate)
        {
            Student[] students = GetAll();
            var result = students.Where(m => m.Birthday > startDate && m.Birthday < endDate).ToArray();
            return result;  

        }

        public int GetStudentAgeId(int Id)
        {
            Student[] students = GetAll();
            Student student=students.FirstOrDefault(m => m.Id == Id);
            int result = DateTime.Now.Year - student.Birthday.Year;
            return result;
        }
    }
}
