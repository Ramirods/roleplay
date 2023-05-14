using System;
namespace Program;

public class Mago
{
    private int vida=100;
    private string nombre;
    
    private int danio;
    private int defensa;
    public Mago(string nombre,int danio,int defensa)
    {
        this.Name = nombre;
        this.Daño = danio;
        this.Defensa = defensa;
    }
    public string Name{ get{return this.nombre;}set{this.nombre = value;}}

      public int Vida{get{return this.vida;}set{this.vida = value;}}

      public int Daño{get{return this.danio;}set{this.danio = value;}}
      public int Defensa{get{return this.defensa;}set{this.defensa = value;}}

    public void RecibirDaño(int danioRecibido)
    {
         this.vida = this.vida - (danioRecibido - this.defensa);

    }
    public void Curarse()
    {
        this.Vida=100;
    }

}