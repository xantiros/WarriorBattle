using System;
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
            new Weapon("Light Sword +10", 0, 10, 0),
            new Weapon("Heavy Sword +20", 0, 20, 0)
        };

        public void Add(Weapon weapon)
        {
            _weapons.Add(weapon);
        }

        public Weapon Get(Guid id)
            => _weapons.Single(x => x.Id == id);

        public IEnumerable<Weapon> GetAll()
            => _weapons;

        public void GetAttack(Weapon weapon)
        {
           //weapon.Attack +
        }

        public void Remove(Guid id)
        {
            var weapon = Get(id);
            _weapons.Remove(weapon);
        }
    }
}
