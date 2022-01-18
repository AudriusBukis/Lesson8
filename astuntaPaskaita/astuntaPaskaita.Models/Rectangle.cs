using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace astuntaPaskaita
{
    public struct Rectangle
    {
        public double Lenght { get; set; }
        public double Height { get; set; }

        public Rectangle(double lenght, double height)
        {
            Lenght = lenght;
            Height = height;
        }

        public  double AreaRectengle()
        {
            return (double)(Lenght * Height);
        }
        public void RectaglePrintAll()
        {
            Console.WriteLine($"Rectangle lenght : {Lenght}");
            Console.WriteLine($"Rectangle height : {Height}");
            Console.WriteLine($"Rectangle area : {Lenght * Height}");
        }
    }

}
