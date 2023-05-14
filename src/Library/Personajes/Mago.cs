using System;

public class Mago
{
    private int vida=100;
    public Mago(string name)
    {
        this.Name = name;
    }
    public string Name{get; set; }
    public int Vida{get; set; }
    public int Daño{get; set; }
    public int Defensa{get; set; }

    public void RecibirDaño(int dañoRecibido)
    {
        this.Vida-=Vida-dañoRecibido;

    }
    public void Curarse()
    {
        this.Vida=100;
    }

}