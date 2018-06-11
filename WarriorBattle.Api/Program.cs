using System;
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

            var warr1 = warriorService.Get(1);
            var warr2 = warriorService.Get(2);

            Console.WriteLine("Start the fight: {0} versus {1} \n",
            warr1.Name,
            warr2.Name);

            foreach (var item in inMemoryWarriorRepository.GetAll())
            {
                Console.WriteLine($"Name: {item.Name},  Health: {item.Health}, Attack: {item.AttMax}, Block: {item.BlockMax}");
            }
            Console.WriteLine("\n");

            var attack1 = warriorService.Attack(warr1.WarriorId, 10);
            Console.WriteLine($"{warr1.Name} attack with: {attack1}");

            var block = warriorService.Block(warr2);
            Console.WriteLine($"{warr2.Name} block: {block}");

            warriorService.Training(warr1);
            Console.WriteLine($"{warr1.Name} New Health: {warr1.Health}");



            Console.ReadKey();
        }
    }
}
