using System;
using System.Collections.Generic;
using System.Text;
using WarriorBattle.Infrastructure.DTO;

namespace WarriorBattle.Infrastructure.Services
{
    public interface IWarriorService
    {
        WarriorDto Get(int warriorId);
        void Create(int warriorId, string name, double health, double attMax, double blockMax);
    }
}
