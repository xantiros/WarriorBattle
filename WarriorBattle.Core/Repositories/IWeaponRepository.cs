using System;
using System.Collections.Generic;
using System.Text;
using WarriorBattle.Core.Domain;

namespace WarriorBattle.Core.Repositories
{
    public interface IWeaponRepository
    {
        Weapon Get(Guid id);
        IEnumerable<Weapon> GetAll();
        void Add(Weapon weapon);
        void Remove(Guid id);
    }
}
