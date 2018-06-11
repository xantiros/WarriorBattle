using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarriorBattle.Core.Domain;
using WarriorBattle.Core.Repositories;

namespace WarriorBattle.Infrastructure.Repositories
{
    public class InMemoryWarriorRepository : IWarriorRepository
    {
        private static ISet<Warrior> _warriors = new HashSet<Warrior>()
        {
           // new Warrior(1, "Maximus", 500, 50, 20),
           // new Warrior(2, "Olimpus", 500, 50, 20)
        };

        public Warrior Get(int id)
            => _warriors.Single(x => x.WarriorId == id);

        public IEnumerable<Warrior> GetAll()
            => _warriors;

        public void Add(Warrior warrior)
        {
            _warriors.Add(warrior);
        }

        public void Remove(int id)
        {
            var warrior = Get(id);
            _warriors.Remove(warrior);
        }

        //random numbers
        Random rdn = new Random();

        public void Training(Warrior warrior)
        {
            warrior.SetHealth(warrior.Health + rdn.Next(10, 51));
            warrior.SetAttMax(warrior.AttMax + rdn.Next(1, 11));
            warrior.SetBlockMax(warrior.BlockMax + rdn.Next(1, 6));
        }

        public double Attack(Warrior warrior)
        {
            return rdn.Next(1, (int)warrior.AttMax);
        }

        public double Block(Warrior warrior)
        {
            return rdn.Next(1, (int)warrior.BlockMax);
        }


    }
}
