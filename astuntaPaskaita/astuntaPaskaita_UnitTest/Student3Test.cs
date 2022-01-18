using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using astuntaPaskaita.Structures;

namespace astuntaPaskaita_UnitTest
{
    public class Student3Test
    {
        [Fact]
        public void Test_Averenge_Function_Of_Semester()
        {
            
            var student = new Student3("Tadas");
            
           
                student.FirstSemester.Add(6);
                student.FirstSemester.Add(7);
                student.FirstSemester.Add(5);

            Assert.Equal<double>(6.0, student.SemesterAverange(student.FirstSemester));

        }
        [Fact]
        public void Test_Averenge_Function_Of_Year()
        {

            var student = new Student3("Tadas");


            student.FirstSemester.Add(6);
            student.FirstSemester.Add(7);
            student.FirstSemester.Add(5);

            student.SecondSemester.Add(8);
            student.SecondSemester.Add(9);
            student.SecondSemester.Add(7);

            student.ThirdSemester.Add(7);
            student.ThirdSemester.Add(8);
            student.ThirdSemester.Add(6);


            Assert.Equal<double>(7.0, student.YearAverange());

        }
    }
}
