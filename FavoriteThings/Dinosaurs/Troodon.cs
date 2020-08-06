using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Dinosaurs
{
    class Troodon
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public EconomicTheories Theory { get; set; }

        private bool _isAngry;

        public Troodon(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Argue(EconomicTheories theory)
        {
            if (_isAngry == false)
            {
                Console.WriteLine($"You argue that {theory} is best. {Name} looks pretty upset about it! \r\n");
                _isAngry = true;
                Theory = theory;
            }
            else
            {
                Console.WriteLine($"{Name} is still trying to process what you said about {Theory}. \r\nPlease try again later.\r\n");
            }
        }

        public void Sing()
        {
            if (_isAngry == true)
            {
                Console.WriteLine($"{Name} is somehow soothed by your tone-deaf humming \r\n");
                _isAngry = false;
            }
            else
            {
                Console.WriteLine($"{Name} just stares blankly at you. \t\n They've been alive {Age} years and still don't have time for your crap.\r\n");
            }
        }

        public void TrDemo(Troodon c)
        {
            do
            {
                c.Argue(Troodon.EconomicTheories.Agrarianism);

                // output reflects change in private field i.e he's too mad to wear anything else!
                c.Argue(Troodon.EconomicTheories.Feudalism);

                // now we sing to soothe the angry dino
                c.Sing();

                // the soothed dino is now ready to wear the pary hat!
                c.Argue(Troodon.EconomicTheories.Feudalism);

                // let's sing again to sooth the dino once more
                c.Sing();

                // now we'll sing to him again -- but it won't have the same effect
                c.Sing();

                Console.WriteLine("Continue?");

                var input = Console.ReadLine();

                var cont = input?.ToLower();

                if ((cont == "y") || (cont == "n"))
                    break;
            } while (true);
        }

        public enum EconomicTheories
        {
            Socialism,
            Capitalism,
            Agrarianism,
            CorproAnarchism,
            Feudalism
        }
    }
}
