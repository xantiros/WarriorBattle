using System;
using System.Collections.Generic;
using System.Text;
using WarriorBattle.Core.Domain;

namespace WarriorBattle.Infrastructure.Services
{
    public interface IWeaponServices
    {
        void Use(Warrior warrior);
    }
}
