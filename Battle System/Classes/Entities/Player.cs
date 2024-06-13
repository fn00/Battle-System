using Battle_System.Classes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_System.Classes.Entities
{
    public class Player : Entity
    {
        protected string ClassName;
        public Player(string name) : base(name)
        {
            GiveItem(new Item("food", "some food"));
            GiveItem(new Item("torch", "a torch"));
            GiveItem(new Item("map", "a map"));
            ClassName = "None";
        }
        internal void GiveItem(Item item)
        {
            
        }
        public string GetClassName()
        {
            return ClassName;
        }
    }
    public class Fighter : Player
    {
        public Fighter(string name) : base(name) 
        {
            strength = 5;
            hp = 10;
            ClassName = "Fighter";
            EquipItem(new Weapon("sword", "a basic sword", 1));
        }
    }

    public class Rogue : Player
    {
        public Rogue(string name) : base(name)
        {
            strength = 7;
            hp = 8;
            ClassName = "Rogue";
            EquipItem(new Weapon("bow", "a basic bow", 1));
        }
        public override int Attack()
        {
            Console.WriteLine("You shoot the enemy from afar");
            return 7;
        }
    }

    public class Tank : Player
    {
        public Tank(string name) : base(name)
        {
            strength = 3;
            hp = 13;
            ClassName = "Tank";
            EquipItem(new Weapon("mace", "a basic mace", 1));
        }
        public override int Attack()
        {
            Console.WriteLine("You bludgeon the enemy");
            return 3;
        }
    }
}
