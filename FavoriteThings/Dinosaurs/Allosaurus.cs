using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Dinosaurs
{
    class Allosaurus
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public int Age { get; set; }

        private bool _isAngry;

        public Allosaurus(string name, int age, string color)
        {
            Name = name;
            Color = color;
            Age = age;
        }

        public void Paint(string color)
        {
            if (_isAngry == false)
            {
                Console.WriteLine($"You painted {Name}, {color}. They look pretty upset about it! \r\n");
                _isAngry = true;
            }
            else
            {
                Console.WriteLine($"{Name} is too angry for you to paint right now! Better stay away! \r\n");
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
                Console.WriteLine($"{Name} just stares blankly at you.  \r\n \r\nThey've been alive {Age} years and still don't have time for your crap.\r\n");
            }
        }

        public void ADemo(Allosaurus c)
        {
            do
            {
                c.Paint("Red");

                // output reflects change in private field i.e he's too mad to wear anything else!
                c.Paint("Green");

                // now we sing to soothe the angry dino
                c.Sing();

                // the soothed dino is now ready to wear the pary hat!
                c.Paint("Red");

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
    }
}
