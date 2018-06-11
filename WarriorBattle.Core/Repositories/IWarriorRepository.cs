using System;
using System.Collections.Generic;
using System.Text;
using WarriorBattle.Core.Domain;

namespace WarriorBattle.Core.Repositories
{
    public interface IWarriorRepository
    {
        Warrior Get(int id);
        IEnumerable<Warrior> GetAll();
        void Add(Warrior warrior);
        void Remove(int id);
        void Training(Warrior warrior);
        double Attack(Warrior warrior);
        double Block(Warrior warrior);
    }
}
