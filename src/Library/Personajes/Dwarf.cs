using System.Collections.Generic;
namespace RoleplayGame
{
    public class Dwarf : ICharacters
    {
        public string name { get; set; }
        public int health { get; set; } 
        public int attack { get; set; }
        public int defense { get; set; }
           List<IItems> inventory = new List<IItems>();

        public Dwarf(string name, int attack, int defense)
        {
            this.name = name;
            this.attack = attack;
            this.defense = defense;
            this.health = 100;
            List<IItems> inventory = new List<IItems>();
        } 

        public void PickUpItem(IItems item)
        {
            this.inventory.Add(item);
        }
        public void EquipItems(string item)
        {

            for (int i = 0; i < inventory.Count; i++ )
            {

                if(inventory[i].Name == item)
                {
                    if(inventory[i].type == "Attack")
                    {
                        this.attack += inventory[i].Value;
                    }
                     else if(inventory[i].type == "Defense")
                    {
                        this.defense += inventory[i].Value;
                    }
                }
            }
        }

        

        public void ReceiveAttack(int power)
        {
            if (this.defense < power)
            {
                this.health -= power - this.defense;
            }
        }

        public void Cure()
        {
            this.health = 100;
        }
    }
}