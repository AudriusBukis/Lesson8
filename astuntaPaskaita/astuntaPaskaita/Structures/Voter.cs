using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace astuntaPaskaita
{
    internal struct Voter
    {
        public Guid Id { get; private set; }
        public int Vote { get; private set; }

        public Voter(Guid id)
        {
            Id = id;
            Vote = new Random().Next(1,3);
        }
    }
}
