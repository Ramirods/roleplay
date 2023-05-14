using System;
namespace Program;

public class Mago
{
    private string nombre;
    private int vida;
    private int danio;
    private int defensa;

    public Mago(string nombre,int vida,int danio,int defensa)
    {
        this.Name = nombre;
        this.Vida = vida;
        this.Danio = danio;
        this.Defensa = defensa;
    }
    
    public string Name{ get{return this.name;}set{this.name = value;}}
    public int Vida{get{return this.vida;}set{this.vida = value;}}
    public int Danio{get{return this.danio;}set{this.danio = value;}}
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