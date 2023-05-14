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
        public void ReceiveAttackDwarf()
        {
            int expected = 90;
            Dwarf legolas = new Dwarf ("Tony1", 10, 10);
            Dwarf enano1  = new Dwarf("Tony", 20, 10);
            legolas.ReceiveAttack(enano1.attack);
            Assert.AreEqual(legolas.health, expected); 
       
        }
        
        [Test]
        public void ReceiveAttackWizard()
        {
            int expected =40 ;
            Wizard wizard1 = new Wizard ("wizard1",10,10);
            Wizard wizard2 = new Wizard ("wizard2",70,20);
            wizard1.ReceiveAttack(wizard2.attack);
            Assert.AreEqual(wizard1.health,expected);

        }
        [Test]
        public void CureHealthWizard()
        {
            int expected = 100;
            Wizard wizard1 = new Wizard ("wizard1",10,10);
            Wizard wizard2 = new Wizard ("wizard2",70,20);
            wizard1.ReceiveAttack(wizard2.attack);
            wizard1.Cure();
            Assert.AreEqual(wizard1.health,expected);
        }
    }
}