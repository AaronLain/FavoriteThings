using System;
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
    }
}

