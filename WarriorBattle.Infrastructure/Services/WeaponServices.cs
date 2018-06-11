using System;
using System.Collections.Generic;
using System.Text;
using WarriorBattle.Core.Domain;
using WarriorBattle.Core.Repositories;

namespace WarriorBattle.Infrastructure.Services
{
    public class WeaponServices : IWeaponServices
    {
        private readonly IWeaponRepository _weaponRepository;

        private readonly IWarriorRepository _warriorRepository;

        public WeaponServices(IWeaponRepository weaponRepository)
        {
            _weaponRepository = weaponRepository;
        }
        public void Use(Warrior warrior)
        {
            //var abc = _weaponRepository.
            //warrior.SetAttMax(warrior.AttMax + _weaponRepository.);
        }
    }
}
