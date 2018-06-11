using System;
using System.Collections.Generic;
using System.Text;

namespace WarriorBattle.Core.Domain
{
    public class Weapon
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public int Health { get; protected set; }
        public int Attack { get; protected set; }
        public int Defense { get; protected set; }
        public DateTime CreatedAt { get; protected set; }

        protected Weapon()
        {

        }

        public Weapon(string name, int health, int attack, int defense)
        {
            Id = new Guid();
            Name = name;
            Health = health;
            Attack = attack;
            Defense = defense;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
