using System;
using System.Collections.Generic;
using System.Text;
using WarriorBattle.Core.Domain;
using WarriorBattle.Core.Repositories;
using WarriorBattle.Infrastructure.DTO;

namespace WarriorBattle.Infrastructure.Services
{
    public class WarriorService : IWarriorService
    {
        private readonly IWarriorRepository _warriorRepository;

        public WarriorService(IWarriorRepository warriorRepository) //konstruktor
        {
            _warriorRepository = warriorRepository;
        }

        public WarriorDto Get(int warriorId)
        {
            var warrior = _warriorRepository.Get(warriorId); 
            return new WarriorDto
            {
                WarriorId = warrior.WarriorId,
                Name = warrior.Name,
                Health = warrior.Health,
                AttMax = warrior.AttMax,
                BlockMax = warrior.BlockMax
            };
        }

        public void Create(int warriorId, string name, double health, double attMax, double blockMax)
        {
            var warrior = new Warrior(warriorId, name, health, attMax, blockMax);
            _warriorRepository.Add(warrior);
        }


    }
}
