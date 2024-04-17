using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();



        static Repository()
        {
            _courses = new List<Course>()
            {
              new Course { Id = 1, Title = "asp kurs" , Description ="nice kurs" ,Image = "asp.jpeg"},
              new Course { Id = 2, Title = "django kurs" , Description ="nice kurs", Image = "dj.png"},
              new Course { Id = 3, Title = "js kurs" , Description ="nice kurs" , Image = "js.jpeg"},


            };
        }
 


        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }

        public static Course? GetById(int id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }
    }
}