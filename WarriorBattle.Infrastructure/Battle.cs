using System;
using System.Collections.Generic;
using System.Text;
using WarriorBattle.Infrastructure.DTO;
using WarriorBattle.Infrastructure.Services;

namespace WarriorBattle.Api
{
    public class Battle
    {
        // This is a utility class so it makes sense
        // to have just static methods

        // Recieve both Warrior objects
        public static void StartFight(WarriorService warriorService, WarriorDto warrior1, WarriorDto warrior2)
        {
            //loop giving each warrior a chance to 
            //attack and block each turn until
            //1 dies
            while (true)
            {
                if (GetAttackResult(warriorService, warrior1, warrior2) == true)
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if (GetAttackResult(warriorService, warrior2, warrior1) == true)
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                Random random = new Random();
                if (random.Next(0, 2) == 1)
                {
                    warriorService.Training(warrior1);
                    Console.WriteLine($"{warrior1.Name} was training and his new attributes are:");
                    Console.WriteLine($"Health: {warrior1.Health}, ");
                    Console.WriteLine($"Attack: {warrior1.AttMax},");
                    Console.WriteLine($"Defense {warrior1.BlockMax} \n");

                }
                else if (random.Next(0, 2) == 1)
                {
                    warriorService.Training(warrior2);
                    Console.WriteLine($"{warrior2.Name} was training and his new attributes are:");
                    Console.WriteLine($"Health: {warrior2.Health}, ");
                    Console.WriteLine($"Attack: {warrior2.AttMax},");
                    Console.WriteLine($"Defense {warrior2.BlockMax} \n");
                }
            }
        }

        //GetAttackResult
        //WarriorA, WarriorB
        public static bool GetAttackResult(WarriorService warriorService, WarriorDto warriorA, WarriorDto warriorB)
        {
            //Calculate 1 warriors attack and the other block
            double warAAttkAmt = warriorService.Attack(warriorA);
            double warBBlkAmt = warriorService.Block(warriorB);

            // Subtract block from attack
            double dmg2WarB = warAAttkAmt - warBBlkAmt;

            // If there was damage subtract that from the health
            if (dmg2WarB > 0) // atak nie może być ujemny
            {
                //warriorB.Health -= dmg2WarB;
                warriorService.SetHealth(warriorB, (int)warriorB.Health - (int)dmg2WarB);

                // Print out info on who attacked who and for how
                // much damage
                Console.WriteLine("{0} Attacks {1} and Deals {2} Damage",
                warriorA.Name, //warriorA.Name,
                warriorB.Name, //warriorB.Name,
                dmg2WarB);
            }
            else
            {
                dmg2WarB = 0;

                Console.WriteLine("{0} Attacks {1} and the attack with {2} damage was blocked.",
                warriorA.Name, //warriorA.Name,
                warriorB.Name, //warriorB.Name,
                warAAttkAmt);
            }

            // Provide output on the change to health
            Console.WriteLine("{0} Has {1} Health\n",
            warriorB.Name, //warriorB.Name,
            warriorB.Health);

            // Check if the warriors health fell below
            // zero and if so print a message and send
            // a response that will end the loop
            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has Died and {1} is Victourious\n",
                    warriorB.Name, //warriorB.Name,
                    warriorA.Name); //warriorA.Name);

                return true;
            }
            else return false;
        }
    }
}
