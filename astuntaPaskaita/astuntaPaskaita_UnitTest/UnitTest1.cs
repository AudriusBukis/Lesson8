using astuntaPaskaita;
using astuntaPaskaita.Structures;
using System;
using Xunit;

namespace astuntaPaskaita_UnitTest
{
    public class UnitTest1
    {
        /* Papildyti prieð tai
        darytà savarankiðkà
        darbà 2 ir 3 unit
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

        /*Sukurti funkcijà kuri
        pverèia stringà ir paraðyti
        jai testus su ilgu stringu, su
        stringu ið 1 simbolio, su
        tuðèiu stringu*/

        /*Paraðyti metodà, kuris
        gauna 1 int parametrà,
        metodas turi graþinti true, jei
        skaièius yra lyginis ir false –
        jei ne. Sukurti testus.*/
    }


}
