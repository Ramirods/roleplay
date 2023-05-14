namespace RoleplayGame;
public class Cane : IItems
{
    private string name; 
    public Cane (string name)
    {
        this.name = name;
    }
    public string Name 
    {
        get
        {
            return name;
        }
    }
    public string type
    {
        get
        {
            return "Attack";
        }
    }
    public int Value
    {   
        get
        {
            return 23;
        }
    }
}
