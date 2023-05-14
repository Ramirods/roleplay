using System;
using RoleplayGame;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Dwarf guillermo = new Dwarf ("Guillermo",0,0,100);
            Bow maze = new Bow("maze");
            guillermo.PickUpItem(maze);
            guillermo.EquipItems("maze");
            Console.WriteLine(guillermo.attack);
            Elfo elfo1 = new Elfo("Elfanfarron", 100, 0, 0);
            Maze maze = new Maze("Rompedor", 40, 20);
            Wizard wizard1 = new Wizard("Eduard",0,0);
            Broom broom1 = new Broom("broom1");
            wizard1.PickUpItem(broom1);
            wizard1.EquipItems("broom1");
            Console.WriteLine(wizard1.attack);
            /*
            Enano enanoVirgo1  = new Enano("Tony", 100 , 0, 0);
            Enano enano1  = new Enano("Tony", 100 , 0, 0);
            Pony pony1 = new Pony("Facu", 10, 10);
            Mazo mazo1 = new Mazo("Rompedor", 40, 20);
            
            Escudo escudo1 = new Escudo("Muro", 10, 50);
            Varita varita1 = new Varita("Palito", 80, 10);
            Mago mago1 = new Mago("Roberto",100, 0, 0);
            Escoba escoba1 = new Escoba("Barredora", 20, 10);
            Baston baston1 = new Baston("Vencedor", 40, 20);
            elfo1.AgregarItem(mazo1);
            Console.WriteLine($"{elfo1.Danio}, {elfo1.Defensa}");
            */
        }
    }
}
