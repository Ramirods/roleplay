using System;
namespace Program;

public class Mago
{
    private string name;
    private int vida;
    private int daño;
    private int defensa;

    public Mago(string name,int vida,int daño,int defensa)
    {
        this.Name = name;
        this.Vida = vida;
        this.Daño = daño;
        this.Defensa = defensa;
    }
    public string Name{ get{return this.name;}set{this.name = value;}}

      public int Vida{get{return this.vida;}set{this.vida = value;}}

      public int Daño{get{return this.daño;}set{this.daño = value;}}
      public int Defensa{get{return this.defensa;}set{this.defensa = value;}}

    public void RecibirDaño(int dañoRecibido)
    {
         this.vida = this.vida - (dañoRecibido - this.defensa);

    }
    public void Curarse()
    {
        this.Vida=100;
    }

}