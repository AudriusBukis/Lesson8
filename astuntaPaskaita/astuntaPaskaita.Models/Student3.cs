using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace astuntaPaskaita.Structures
{
    public struct Student3
    { 
  
        public string Name { get; set; }
        public List<int> FirstSemester { get;  set; }
        public List<int> SecondSemester { get;  set; }
        public List<int> ThirdSemester { get; set; }

        public Student3(string name): this()
        {
            Name = name;
            FirstSemester = new List<int>() ;
            SecondSemester = new List<int>();
            ThirdSemester = new List<int>();
        }

        public void DelateSemesterGrade(int gradeYouWantDetale, List<int> semester)
        {
            semester.Remove(gradeYouWantDetale);
        }
        public void AddSemesterGrade(int gradeYouWantAdd, List<int> semester)
        {
            semester.Add(gradeYouWantAdd);
        }
        public double SemesterAverange(List<int> semester)
        {
            int sumOfElemets = 0;
            foreach (var item in semester)
            {
                sumOfElemets += item;
            }
            return (double)sumOfElemets / semester.Count();
        }

        public double YearAverange()
        {
            return (SemesterAverange((List<int>)FirstSemester) 
                + SemesterAverange((List<int>)SecondSemester)
                 + SemesterAverange((List<int>)ThirdSemester)) / 3;
        }
    }
}
