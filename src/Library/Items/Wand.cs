namespace RoleplayGame
{
    public class Wand : IItems
    {

        private string name; 
        public Wand (string name)
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
                return "Atack";
            }
        }
        public int Value
        {
            get
            {
                return 30;
            }
        }
    }
}