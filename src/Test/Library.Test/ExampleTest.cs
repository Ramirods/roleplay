using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class ExampleTest
    {
        [Test]
        public void dummyTest()
        {
            Assert.True(true);
        }

        [Test]
        public void RecibirDanio1()
        {
            int expected = 90;
            Dwarf legolas = new Dwarf ("Tony1", 10, 10);
            Dwarf enano1  = new Dwarf("Tony", 20, 10);
            legolas.ReceiveAttack(enano1.attack);
            Assert.AreEqual(legolas.health, expected); 
       
        }

         [Test]
        public void RecibirDanio2()
        {
            int expected = 70;
            Elf bajito = new Elf ("Roby1", 10, 10);
            Elf elfo1  = new Elf("Robyy", 20, 10);
            bajito.ReceiveAttack(elfo1.attack);
            Assert.AreEqual(bajito.health, expected); 
       
        }

        [Test]
        public void RecibirDañoMago()
        {
            
        }
    }
}