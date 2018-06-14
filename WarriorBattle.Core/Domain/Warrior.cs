using System;
using System.Collections.Generic;
using System.Text;

namespace WarriorBattle.Core.Domain
{
    public class Warrior
    {
        //name health attack maximum block minimum
        public int WarriorId { get; protected set; } //na guid? 
        public string Name { get; protected set; }
        public double Health { get; protected set; }
        public double AttMax { get; protected set; }
        public double BlockMax { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }
        public IEnumerable<Weapon> Weapons { get; protected set; } //list of weapons

        protected Warrior()
        {
        }

        public Warrior(int warriorId,
                       string name,
                       double health,
                       double attMax,
                       double blockMax)
        {
            WarriorId = warriorId;
            Name = name;
            Health = health;
            AttMax = attMax;
            BlockMax = blockMax;
            CreatedAt = DateTime.UtcNow;
        }

        public void SetHealth(double health)
        {
            if (health <= 0)
                throw new Exception("Health can not be less than zero.");
            Health = health;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetAttMax(double attmax)
        {
            if (attmax <= 0)
                throw new Exception("Attack can not be less than zero.");
            AttMax = attmax;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetBlockMax(double blockMax)
        {
            if (blockMax <= 0)
                throw new Exception("Block can not be less than zero.");
            BlockMax = blockMax;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
