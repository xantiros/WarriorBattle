using System;
using System.Collections.Generic;
using System.Text;

namespace WarriorBattle.Core.Domain
{
    public class Warrior
    {
        //name health attack maximum block minimum
        public int WarriorId { get; protected set; }
        public string Name { get; protected set; }
        public double Health { get; protected set; }
        public double AttMax { get; protected set; }
        public double BlockMax { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public IEnumerable<Weapon> weapons { get; protected set; } //lista broni

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
            Health = health;
        }

        public void SetAttMax(double attmax)
        {
            AttMax = attmax;
        }

        public void SetBlockMax(double blockMax)
        {
            BlockMax = blockMax;
        }
    }
}
