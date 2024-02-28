using KodlamaIOHomework.Abstract;
using KodlamaIOHomework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOHomework.Concreate
{ 
    public class CourseDal : ICourseDal
    {
        private List<Course> _courses;

        public CourseDal()
        {
            _courses = new List<Course>
        {
            new Course{Id = 1,Name="c sharp", CategoryId = 1, InstructorId = 1, },
            new Course{Id = 2,Name="java" ,CategoryId = 3, InstructorId = 1,},
            new Course{Id = 3,Name="python" ,CategoryId = 2, InstructorId = 2},
        };
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Add(Course course)
        {
            _courses.Add(course);
            Console.WriteLine("Kurs başarıyla eklendi ");
        }

        public void Update(Course course)
        {
               
            Console.WriteLine("Kurs başarıyla güncellendi ");
        }

        public void Delete(Course course)
        {
            _courses.Remove(course);
            Console.WriteLine("Kurs başarıyla silindi ");
        }
    }
    
}
