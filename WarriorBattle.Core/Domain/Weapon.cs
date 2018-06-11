using System;
using System.Collections.Generic;
using System.Text;

namespace WarriorBattle.Core.Domain
{
    public class Weapon
    {
        public Guid guid { get; protected set; }

        public string Name { get; protected set; }

        public int Health { get; protected set; }

        public int Attack { get; protected set; }

        public int Defense { get; protected set; }

        protected Weapon()
        {

        }
    }
}
