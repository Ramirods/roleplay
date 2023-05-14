using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Enano enano1  = new Enano("Tony", 100 , 0, 0);
            Pony pony1 = new Pony("Facu", 10, 10);
            Mazo mazo1 = new Mazo("Rompedor", 40, 20);
            Elfo elfo1 = new Elfo("Elfanfarron", 100, 0, 0);
            Escudo escudo1 = new Escudo("Muro", 10, 50);
            Varita varita1 = new Varita("Palito", 80, 10);
            Mago mago1 = new Mago("Roberto",100, 0, 0);
            Escoba escoba1 = new Escoba("Barredora", 20, 10);
            Baston baston1 = new Baston("Vencedor", 40, 20);
            elfo1.AgregarItem(mazo1);
            Console.WriteLine($"{elfo1.Danio}, {elfo1.Defensa}");
        }
    }
}
