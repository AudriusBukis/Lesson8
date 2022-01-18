using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace astuntaPaskaita
{
    public struct Book
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }    
        public string BorrowersName { get; private set; }   
        public DateTime BorrowDate { get; private set; }

        public Book(string name, string borrowersName, DateTime borrowDate)
        {
            Id = Guid.NewGuid();
            Name = name;
            BorrowersName = borrowersName;
            BorrowDate = borrowDate;
        }

        public int GetDateBorrowed()
        {
            return (DateTime.Now - BorrowDate).Days;
        }
    }
}
