﻿using System;
using System.Collections.Generic;
using WarriorBattle.Infrastructure.DTO;
using WarriorBattle.Infrastructure.Repositories;
using WarriorBattle.Infrastructure.Services;

namespace WarriorBattle.Api
{
    class Program
    {
        static void Main(string[] args)
        {
            InMemoryWarriorRepository inMemoryWarriorRepository = new InMemoryWarriorRepository();

            WarriorService warriorService = new WarriorService(inMemoryWarriorRepository);

            warriorService.Create(1, "Maximus", 500, 60, 20);

            warriorService.Create(2, "Olimpus", 500, 60, 20);

            Console.WriteLine("Start the fight: {0} versus {1} \n",
            warriorService.Get(1).Name,
            warriorService.Get(2).Name);

            WarriorDto warriorDto = new WarriorDto();



            var attack1 = warriorService.Attack(warriorService.Get(1).WarriorId, 10);
            Console.WriteLine($"Attack with: {attack1}");

            var block = warriorService.Block(warriorService.Get(1));
            Console.WriteLine($"Block: {block}");

            var all = inMemoryWarriorRepository.GetAll();

            foreach (var item in all)
            {
                Console.WriteLine($"{item.Name},  {item.Health}, {item.AttMax}");
                //Console.WriteLine(warriorService.Get(item.WarriorId).ToString());
            }

            

            Console.WriteLine(inMemoryWarriorRepository.GetAll());



            Console.ReadKey();
        }
    }
}
