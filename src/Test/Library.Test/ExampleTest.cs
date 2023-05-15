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
        public void EquipItemsElf()
        {
            int expected = 24;
            Elf legolas = new Elf("Tony1", 10, 10);
            Dwarf enano1 = new Dwarf("Tony", 20, 10);
            Maze maze1 = new Maze("mazo");
            legolas.PickUpItem(maze1);
            legolas.EquipItems("mazo");
            Assert.AreEqual(legolas.attack, expected);

        }


        [Test]
        public void ReceiveAttackElf()
        {
            int expected = 80;
            Dwarf enano1 = new Dwarf("Tony", 20, 10);
            Elf legolas = new Elf("Tony1", 10, 20);
            legolas.ReceiveAttack(enano1.attack);
            Assert.AreEqual(legolas.health, expected);

        }

        [Test]
        public void ReceiveAttackDwarf()
        {
            int expected = 40;
            Dwarf dwarf1 = new Dwarf("dwarf1", 10, 10);
            Wizard wizard2 = new Wizard("wizard2", 70, 20);
            dwarf1.ReceiveAttack(wizard2.attack);
            Assert.AreEqual(dwarf1.health, expected);

        }
        [Test]
        public void CureHealthWizard()
        {
            int expected = 100;
            Wizard wizard1 = new Wizard("wizard1", 10, 10);
            Elf elf2 = new Elf("wizard2", 70, 20);
            wizard1.ReceiveAttack(elf2.attack);
            wizard1.Cure();
            Assert.AreEqual(wizard1.health, expected);
        }
    }
}