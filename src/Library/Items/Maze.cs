namespace RoleplayGame
{
    public class Maze : IItems
    {

        private string name; 
        public Maze (string name)
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
                return 14;
            }
        }
    }
}