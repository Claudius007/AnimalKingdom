using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AnimalKingdom
{
    class Mountain_Lion : Animal
    {
        public int hunger_value { get; set; }
        public int hunger_threshold { get; set; }
        public bool ability_to_look_around { get; set; }



        public Mountain_Lion(int hunger_value, int hunger_threshold, bool ability)
        {
            this.name = "Simba the Lion";
            this.hunger_value = hunger_value;
            this.hunger_threshold = hunger_threshold;
            this.ability_to_look_around = ability;
        }


        public bool Hungry()
        {
            Deer daisy_to_simba = new Deer(5,2,true);
            return daisy_to_simba.Hungry();
        }

        public void what_to_do()
        {
            if (Hungry())
            {
                Eat();
            }
            else
                Mate();
        }

        public void Mate()
        {
            if (hunger_value > hunger_threshold)
            {
                Console.WriteLine("looking for another Lion to mate with");

                Thread.Sleep(3000);
            }

            var rand = new Random();
            int min = 1;
            int max = 3;

            int to_check_if_mate_found = rand.Next(min, max);

            if (to_check_if_mate_found == 2)
            {
                Console.WriteLine($"Heyy I am {name} and I have found a mate");
                Thread.Sleep(3000);
                Chance();
            }

            else
            {
                Console.WriteLine($"No mate around");
                Thread.Sleep(3000);
                Wander();
            }
        }

        public void Chance()
        {
            int min = 1;
            int max = 3;
            var rand = new Random();
            int chance_value = rand.Next(min, max);
            if (chance_value == 2)
            {
                Console.WriteLine($" the chance of spawning a new Lion with this mate I found is high because chance is {chance_value}");
            }
            else
            {
                Console.WriteLine($" the chance of spawning a new Lion with this mate I found is low because chance is {chance_value}");
            }

        }

        public void Wander()
        {
            Console.WriteLine($"Wandering randomly");
        }

        public void Time_Check()
        {
            Console.Write($"I am {name}, when last did I eat? ");
            int time_in_days = Convert.ToInt32(Console.ReadLine());

            if (time_in_days > 4)
            {
                Console.WriteLine($"{name} dies now, too hungry :( ");

            }
            else
            {
                Thread.Sleep(3000);
                Wander();
            }


        }

        public void Eat()
        {
            Console.Write($"{name} is hungry, how many deers are in this forest? ");
            int num_of_deer = Convert.ToInt32(Console.ReadLine());

            if (num_of_deer >= 1)
            {

                Tree tree = new Tree(num_of_deer);

                int trees_left = tree.count - 1;

                hunger_value = hunger_value + 1;
                Console.WriteLine($"{name} ate a tree and now it is removed from the world. \n trees left:  { trees_left} \n hunger value: { hunger_value }");

                while ((hunger_value < hunger_threshold) && (trees_left > 1))
                {
                    Eat();
                }
            }

            else
                Time_Check();
        }

    }
}


