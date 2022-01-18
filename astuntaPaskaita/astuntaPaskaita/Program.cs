using astuntaPaskaita.Structures;
using System;
using System.Collections.Generic;
using System.Linq;

namespace astuntaPaskaita
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //lesson8task1();
            //lesson8task2();
            //lesson8task3();
            //lesson8task4();
            lesson8task5();
            //lesson8task6();
            //lesson8task7();
            //lesson8task8();


            static void lesson8task1()
            {
                /* Sukurti struktūrą Mokinys su laukais
                vardas, pavarde, kurso pradžia ir
                kurso pabaiga.
                Sukurti kintamąjį mokinys užpildyti
                laukus ir išvesti į konsolę*/
                Console.WriteLine("lesson8 task1");
                var student = new Student("Audrius", "Bukis", DateTime.Now.AddDays(-30), DateTime.Now.AddDays(+180));
                student.PrintAll(); 
            }
            static void lesson8task2()
            {
                /* Sukurti struktūrą BibliotekosKyga su
                laukais ID, pavadinimas, skaitytojo
                vardas, paėmimo data. Struktūroje
                sukurti metodą, kuris gražina kiek
                dienų knyga jau pas skaitytoją.
                Padaryti kintamąjį, rezultatą išvesti į
                konsolę. */
                Console.WriteLine("lesson8 task2");
                var book = new Book("Normal People", "Audrius", DateTime.Now.AddDays(-26));
                
                Console.WriteLine($"ID {book.Id}: Book {book.Name} is borrowed {book.GetDateBorrowed()} days, by {book.BorrowersName}");
            }
            static void lesson8task3()
            {
                /* Sukurti struktūrą Stačiakampis su
                laukais ilgis ir plotis. Struktūroje sukurti
                metodą Plotas(). Sukurti 3
                kintamuosius stčiakampis1-
                staciakamis3, užpildyti laukus ir išvesti
                plotus į konsolę. */
                Console.WriteLine("lesson8 task3");
                var myRectengle = new Rectangle(15.5, 29);
                myRectengle.RectaglePrintAll();
                Console.WriteLine($"rectangle area : {myRectengle.AreaRectengle()}");
                
            }
            static void lesson8task4()
            {
                /* Sukurti struktūrą Studentas, su
                laukais ID ir įskaitos rezultatas (bool).
                Sukurti studentų sąrašą
                List<Studentas>, pridėti 5 studentus į
                sąrašą. Atskiroje funkcijoje išvesti
                sąrašą į konsolę. */
                Console.WriteLine("lesson8 task4");
                var list = new List<Student2>();
                
                list.Add(new Student2("Audrius", "Bukis", true));
                list.Add(new Student2("Tadas", "Tadauskis", false));
                list.Add(new Student2("Marius", "Mariauskis", true));
                list.Add(new Student2("Andrius", "Andriukaitis", true));
                list.Add(new Student2("Pranas", "Pranautis", false));
                list.Add(new Student2("Saulius", "Grušas", true));
                list.Add(new Student2("Giedrius", "Giedraitis", true));
                list.Add(new Student2("Donatas", "Miničius", true));
                foreach (var student in list)
                {
                    student.PrintStudentList();
                }

                
            }
            static void lesson8task5()
            {
                /* Sukurti struktūrą Studentas. Joje turi
                būti 3 sąrašai su trimestrų
                pažymiais. Struktūra turi turėti
                metodus trimestro vidurkiui ir
                metiniam pažymiui suskaičiuoti. */
                Console.WriteLine("lesson8 task5");
                var rand = new Random();
                var student = new Student3("Benas");
                for (int i = 0; i < 10; i++)
                {
                    student.FirstSemester.Add(rand.Next(4, 10));
                    student.SecondSemester.Add(rand.Next(4, 10));
                    student.ThirdSemester.Add(rand.Next(4, 10));
                }
                Console.WriteLine($"First semester averange : {student.SemesterAverange(student.FirstSemester)}");
                Console.WriteLine($"Second semester averange : {student.SemesterAverange(student.SecondSemester)}");
                Console.WriteLine($"Third semester averange : {student.SemesterAverange(student.ThirdSemester)}");
                Console.WriteLine($"Year averange : {student.YearAverange()}");
            }
            static void lesson8task6()
            {
                /* Sukurti struktūrą Rinkėjas. Rinkėjas
                turi ID ir požymį, kad prabalsavo.
                Sukurti rinkėjų sąrašą. Atsitiktiniu
                būdu į sąrašą pridėti 10 rinkėjų.
                Parodyti balsavimo statistiką. */
                Console.WriteLine("lesson8 task6");
                var voters = new List<Voter>();
                for (int i = 0; i < 100; i++)
                {
                    voters.Add(new Voter(Guid.NewGuid()));
                }

                var votedForFirst = voters.Where(v => v.Vote == 1).Count();
                var votedForSecond = voters.Where(v => v.Vote == 2).Count();
                Console.WriteLine($"Voted for first: {votedForFirst}");
                Console.WriteLine($"Voted for second: {votedForSecond}");

            }
            static void lesson8task7()
            {
                /* Sukurti 2 struktūras Gyvūnas ir
                ZoologijosSodas. Gyvūnas turi vardą
                ir rūšį. Zoologijos sodas turi
                pavadinimą adresą ir gyvūnų sąrašą.
                Zoologijos sodas turi „mokėti pasakyti“
                kiek viso gyvūnų yra, kiek kokios
                rūšies gyvūnų yra. */
                Console.WriteLine("lesson8 task7");
                var zoo = new AnimalZoo("Dog Cat Zoo ", "Draugystes g.");
                zoo.AddAnimal(new Animals("Donis", "Cat"));
                zoo.AddAnimal(new Animals("Rikis", "Dog"));
                zoo.AddAnimal(new Animals("Blinkis", "Dog"));
                zoo.AddAnimal(new Animals("Murkis", "Cat"));
                zoo.AddAnimal(new Animals("Rainis", "Cat"));
                zoo.AddAnimal(new Animals("Tobis", "Dog"));
                zoo.AddAnimal(new Animals("Tonis", "Dog"));
                zoo.AddAnimal(new Animals("Tigras", "Cat"));
                zoo.AddAnimal(new Animals("Juodis", "Cat"));

                Console.WriteLine($"Number of animals in the zoo : {zoo.AnimalCount()}");
                Console.WriteLine($"Number of Dogs in the zoo is : {zoo.CountSpecies("Dog")}");
                Console.WriteLine($"Number of Cats in the zoo is : {zoo.CountSpecies("Cat")}");

            }
            static void lesson8task8()
            {
                /* Sukurti struktūrą Point, kurioje
                saugome koordinates x ir y. Sukurti
                struktūrą Rectangle su Point tipo
                laukais TopLeft ir BottomRight. Sukurti
                metodą CheckPoint, kuris patikrina ar
                paduotas taškas yra stačiakampio
                viduje */
                Console.WriteLine("lesson8 task8");
                var points = new Point(-10,-26);
               
                var rectangleArea = new Rectangle2(25, -25, -20, 20);

                Console.WriteLine($"Test if point is in rectengle {rectangleArea.CheckPoint(points.CoordineteX, points.CoordineteY)} ");

            }
        }
    }
}
