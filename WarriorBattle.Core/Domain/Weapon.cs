using System;
using System.Collections.Generic;
using System.Text;

namespace WarriorBattle.Core.Domain
{
    public class Weapon //valueObject -> Inmutable
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

        protected Weapon(string name, int health, int attack, int defense)
        {
            Id = new Guid();
            SetName(name);
            SetHealth(health);
            SetAttack(attack);
            SetDefense(defense);
            CreatedAt = DateTime.UtcNow;
        }

        private void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Please set valid weapon name");

            Name = name;
        }
        private void SetHealth(int health)
        {
            if (health < 0)
                throw new Exception("Weapon health can not be less than zero.");

            Health = health;
        }
        private void SetAttack(int attack)
        {
            if (attack < 0)
                throw new Exception("Weapon attack can not be less than zero.");

            Attack = attack;
        }
        private void SetDefense(int defense)
        {
            if (defense < 0)
                throw new Exception("Weapon defense can not be less than zero.");
            Defense = defense;
        }
        public static Weapon Create(string name, int health, int attack, int defense)
            => new Weapon(name, health, attack, defense);
    }
}
