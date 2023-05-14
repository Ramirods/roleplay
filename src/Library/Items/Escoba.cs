public class Escoba
{
    //atributos
    private string nombre {get; set; }
    private int ataque {get; set; }
    private int defensa{get; set; }
    //constructor
    public Escoba(string nombre, int ataque, int defensa){
         this.Nombre = nombre;
         this.Ataque = ataque;
         this.Defensa = defensa;
      }

      //getters and seters
      public string Nombre { get; private set; }

      public int Ataque { get; private set; }
      public int Defensa { get; private set; }
}