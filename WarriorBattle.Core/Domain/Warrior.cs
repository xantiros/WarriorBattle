using System;
using System.Collections.Generic;
using System.Text;

namespace WarriorBattle.Core.Domain
{
    public class Warrior
    {
        //name health attack maximum block minimum
        public Guid WarriorId { get; protected set; }
        public string Name { get; protected set; }
        public double Health { get; protected set; }
        public double AttMax { get; protected set; }
        public double BlockMax { get; protected set; }
        public IEnumerable<Weapon> weapons { get; protected set; } //lista broni

        protected Warrior()
        {

        }

        public Warrior(string name,
                       double health,
                       double attMax,
                       double blockMax)
        {
            WarriorId = Guid.NewGuid();
            Name = name;
            Health = health;
            AttMax = attMax;
            BlockMax = blockMax;
        }
    }
}
