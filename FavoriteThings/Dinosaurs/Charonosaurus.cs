﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Dinosaurs
{
    class Charonosaurus
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Phrase { get; set; }

        private bool _isAngry;

        public Charonosaurus(string name, int age)
        {
            Name = name;
            Age = age;
            Phrase = "";
        }

        public void Insult(string phrase)
        {
            if (_isAngry == false)
            {
                Console.WriteLine($"You called {Name}, a(n) {phrase}. They look pretty upset about it! \r\n");
                _isAngry = true;
                Phrase = phrase;
            }
            else
            {
                Console.WriteLine($"{Name} is still mad after you called them a(n) {Phrase}! Better stay away! \r\n");
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
                Console.WriteLine($"{Name} just stares blankly at you.  \r\n \r\nThey've been alive {Age} years and still don't have time for your crap.");
            }
        }

        public void CDemo(Charonosaurus c)
        {
            do
            {
                c.Insult("Butthead");

                // output reflects change in private field i.e he's too mad to wear anything else!
                c.Insult("Buttface");

                // now we sing to soothe the angry dino
                c.Sing();

                // the soothed dino is now ready to wear the pary hat!
                c.Insult("ButtButt");

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

