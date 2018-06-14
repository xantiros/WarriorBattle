using System;
using System.Collections.Generic;
using WarriorBattle.Infrastructure.DTO;
using WarriorBattle.Infrastructure.Repositories;
using WarriorBattle.Infrastructure.Services;
using WarriorBattle.Infrastructure;

namespace WarriorBattle.Api
{
    class Program
    {
        static void Main(string[] args)
        {
            InMemoryWarriorRepository inMemoryWarriorRepository = new InMemoryWarriorRepository();

            WarriorService warriorService = new WarriorService(inMemoryWarriorRepository);

            warriorService.Create(1, "Maximus", 300, 60, 20);
            warriorService.Create(2, "Olimpus", 300, 60, 20);

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

            Battle battle = new Battle();
            Battle.StartFight(warriorService, warr1, warr2);

            /*
            var attack = warriorService.Attack(warr1);
            Console.WriteLine($"{warr1.Name} attack with: {attack}");

            var block = warriorService.Block(warr2);
            Console.WriteLine($"{warr2.Name} block: {block}");

            Console.WriteLine($"{warr1.Name} health: {warr1.Health}, attack: {warr1.AttMax}, block: {warr1.BlockMax}");
            warriorService.Training(warr1);
            Console.WriteLine($"{warr1.Name} new Health: {warr1.Health}, attack: {warr1.AttMax}, block: {warr1.BlockMax}");

            */

            Console.ReadKey();
        }
    }
}
