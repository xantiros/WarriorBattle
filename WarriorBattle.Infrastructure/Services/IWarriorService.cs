using System;
using System.Collections.Generic;
using System.Text;
using WarriorBattle.Core.Domain;
using WarriorBattle.Infrastructure.DTO;

namespace WarriorBattle.Infrastructure.Services
{
    public interface IWarriorService
    {
        WarriorDto Get(int warriorId);
        void Create(int warriorId, string name, double health, double attMax, double blockMax);
        void Training(WarriorDto warrior);
        int Attack(int warriorId, int attack);
        int Block(WarriorDto warrior);
    }
}
