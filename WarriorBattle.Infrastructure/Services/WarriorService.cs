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

        public WarriorService(IWarriorRepository warriorRepository) //konstruktor, na wejscie dajemy repozytorium
        {
            _warriorRepository = warriorRepository;
        }

        public WarriorDto Get(int warriorId)
        {
            var warrior = _warriorRepository.Get(warriorId); //InMemoryWarriorRepository.Get
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
            _warriorRepository.Add(warrior); //InMemoryWarriorRepository.Add
        }

        //
        Random rdn = new Random();
        //
        public void Training(WarriorDto warrior)
        {
            warrior.Health = warrior.Health + rdn.Next(10, 51);
            warrior.AttMax = warrior.AttMax + rdn.Next(1, 11);
            warrior.BlockMax = warrior.BlockMax + rdn.Next(1, 6);

            //warrior.SetHealth(warrior.Health + rdn.Next(10, 51));
            //warrior.SetAttMax(warrior.AttMax + rdn.Next(1, 11));
            //warrior.SetBlockMax(warrior.BlockMax + rdn.Next(1, 6));
        }

        public int Attack(WarriorDto warrior)
        {
            return rdn.Next(1, (int)warrior.AttMax);
        }

        public int Block(WarriorDto warrior)
        {
            return rdn.Next(1, (int)warrior.BlockMax);
        }
    }
}
