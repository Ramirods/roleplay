namespace RoleplayGame
{
    public class poni : IItems
    {

        private string name; 
        public poni (string name)
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
                return "Defense";
            }
        }
        public int Value
        {   
            get
            {
                return 20;
            }
        }
    }
}