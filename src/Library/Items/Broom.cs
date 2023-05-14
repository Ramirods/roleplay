namespace RoleplayGame;
public class Broom : IItems
{
    private string name; 
    public Broom (string name)
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
            return 5;
        }
    }
}
