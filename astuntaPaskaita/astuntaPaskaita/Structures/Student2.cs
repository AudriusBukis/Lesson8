using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace astuntaPaskaita
{
    internal struct Student2
    {
        // struct ketvirtos uzduoties
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public bool CeditScore { get; private set; }
        //public List<Student2> ListStudent { get; set; }

        /* Sukurti struktūrą Studentas, su
                laukais ID ir įskaitos rezultatas (bool).
                Sukurti studentų sąrašą
                List<Studentas>, pridėti 5 studentus į
                sąrašą. Atskiroje funkcijoje išvesti
                sąrašą į konsolę. */

        public Student2(string firstName, string lastName, bool credisScore) 
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            CeditScore = credisScore;
            //ListStudent = new List<Student2>();
        }
        
        public void PrintStudentList()
        {
            Console.WriteLine();
            Console.Write($"Student ID : {Id}; ");
            Console.Write($"Student : {FirstName} {LastName}; ");
            Console.Write($"Credit Score is positive: {CeditScore}; ");
        }
    }
}
