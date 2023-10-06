using Services_Encapsulation_practice.Models;
using Services_Encapsulation_practice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services_Encapsulation_practice.Controller
{
    internal class StudentController
    {    private StudentService studentService;
        public StudentController()
        {
            studentService = new StudentService();
        }

        public void GetFilteredStudent()
        {
            DateTime startDate = new(1998, 03, 02);
            DateTime endDate = new(2005, 02, 04);
           
            Student[] students = studentService.GetAllStudents(startDate,endDate);
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name}-{student.Birthday.ToString("MM/dd/yyyy")}");
            }
            
        }

        public void GetStudent()
        {
             

            Console.WriteLine(studentService.GetStudentAgeId(2));
        }

       
    }
}
