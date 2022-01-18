using astuntaPaskaita;
using astuntaPaskaita.Structures;
using System;
using Xunit;

namespace astuntaPaskaita_UnitTest
{
    public class UnitTest1
    {
        /* Papildyti prie� tai
        daryt� savaranki�k�
        darb� 2 ir 3 unit
        testais*/

        [Fact]
        public void If_Rectangle_Ares_Not_Returns_Minus_Value()
        {
            var myRectengle = new Rectangle(15.5, 29);

            var result = myRectengle.AreaRectengle();

            Assert.True(result > 0);
        }

        [Fact]
        public void Test_If_AnimalCount_Returns_Corect_Value ()
        {
            // Arrange
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
            //Act
            int count = zoo.AnimalCount();
            //Assert
            Assert.Equal(9, count);
        }


        [Fact]
        public void Test_If_No_Name_Throws_Error()
        {
            // Arrange

            //Act
            var zoo = new AnimalZoo("Dog Cat Zoo ", "Draugystes g.");
            //Assert
            Assert.Throws<ArgumentException>(() => zoo.AddAnimal(new Animals()));
        }

        /*Sukurti funkcij� kuri
        pver�ia string� ir para�yti
        jai testus su ilgu stringu, su
        stringu i� 1 simbolio, su
        tu��iu stringu*/

        /*Para�yti metod�, kuris
        gauna 1 int parametr�,
        metodas turi gra�inti true, jei
        skai�ius yra lyginis ir false �
        jei ne. Sukurti testus.*/
    }


}
