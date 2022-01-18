using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace astuntaPaskaita
{
    public struct Student
    {
        //struct pirmos uzduotes
        public string Name { get; }
        public string LastName { get; }

        public DateTime CourseStartTime { get; private set; }

        public DateTime CourseEndTime { get; private set; }
        
        public Student(string name, string lastName, DateTime courseStartTime, DateTime courseEndTime) 
        {
            Name = name;
            LastName = lastName;
            CourseStartTime = courseStartTime;
            CourseEndTime = courseEndTime;
        }

        public void PrintAll()
        {
            Console.WriteLine($"Student name : {Name}");
            Console.WriteLine($"Student lastname : {LastName}");
            Console.WriteLine($"Course start date : {CourseStartTime}");
            Console.WriteLine($"Course end date : {CourseEndTime}");

        }

       
    }   
}
