﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarriorBattle.Core.Domain;
using WarriorBattle.Core.Repositories;

namespace WarriorBattle.Infrastructure.Repositories
{
    public class InMemoryWeaponRepository : IWeaponRepository
    {
        private static ISet<Weapon> _weapons = new HashSet<Weapon>()
        {
            Weapon.Create("Light Sword +10", 0, 10, 0),
            Weapon.Create("Heavy Sword +20", 0, 20, 0),
            Weapon.Create("Light Sheld +10", 0, 0, 10)
        };

        public void Add(Weapon weapon)
        {
            _weapons.Add(weapon);
        }

        public Weapon Get(Guid id)
            => _weapons.Single(x => x.Id == id);

        public IEnumerable<Weapon> GetAll()
            => _weapons;

        public void Update(Weapon weapon)
        {
            throw new Exception("Can not update weapon yet.");
        }

        public void Remove(Guid id)
        {
            var weapon = Get(id);
            _weapons.Remove(weapon);
        }
    }
}
