using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Los campeones se preparan para la batalla con ustedes: \n");
            Console.WriteLine("Guillermo el rey enano \n");
            Console.WriteLine("Roberto   el elfo del bosque \n");
            Console.WriteLine("wizard1   el mago generico \n");


            Dwarf guillermo = new Dwarf ("Guillermo",0,0);
            Console.WriteLine("El daño de guillermo antes de quiparse los items es:" + guillermo.attack);
            Maze maze = new Maze("maze");
            guillermo.PickUpItem(maze);
            guillermo.EquipItems("maze");
            Console.WriteLine("El daño de guillermo despues de quiparse los items es:" + guillermo.attack);
            
            Elf roberto = new Elf("Roberto",0,0);
            Console.WriteLine("La defensa de roberto antes de quiparse los items es:" + roberto.defense);
            Shield shield = new Shield("shield");
            roberto.PickUpItem(shield);
            roberto.EquipItems("shield");
            Console.WriteLine("Luego de quiparse el item la defensa de roberto es:" + roberto.defense);

            Wizard wizard1 = new Wizard ("wizard1",10,10);
            Console.WriteLine("El daño de wizard1 antes de quiparse los items es:" + wizard1.attack);
            Cane cane1 = new Cane ("cane1");
            wizard1.PickUpItem(cane1);
            wizard1.EquipItems("cane1");
            Console.WriteLine("Luego de quiparse el item el daño de wizard1 es:" + wizard1.attack);

            Console.WriteLine("El mago wizard1 recibe un ataque del mismisimo enano roberto");
            wizard1.ReceiveAttack(guillermo.attack);
            Console.WriteLine("La vida de Wizard1 queda en " + wizard1.health);
            Console.WriteLine("El mago medio herido hace un contrataque y ataca a guillermo");
            guillermo.ReceiveAttack(wizard1.attack);
            Console.WriteLine("La vida de guillermo queda en: " + guillermo.health);
            Console.WriteLine("El enano guillermo termina mal herido y saca un hongo curativo y se restaura la vida");
            guillermo.Cure();
            Console.WriteLine("La vida del enano Guillermo se restaura a: " + guillermo.health);
            Console.WriteLine("El elfo roberto al ver que el enano se cura con hongos sale corriendo por su vida");
            Console.WriteLine("El mago juro verse con guillermo en el PII_RoleplayGame_3_Start");



        }
    }
}
