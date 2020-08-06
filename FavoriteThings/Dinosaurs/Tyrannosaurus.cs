using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Dinosaurs
{
    class Tyrannosaurus
    {
        public string Name { get; set; }

        public int Age { get; set; }

        private bool _isAngry;

        public Tyrannosaurus(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DressUp(string item)
        {
            if (_isAngry == false)
            {
                Console.WriteLine($"You dressed up {Name} in a(n) {item}. They look pretty upset about it! \r\n");
                _isAngry = true;
            }
            else
            {
                Console.WriteLine($"{Name} is too angry for you to dress up right now! Better stay away! \r\n");
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
                Console.WriteLine($"{Name} just stares blankly at you. \r\n \r\nThey've been alive {Age} years and still don't have time for your crap.");
            }
        }

       public void TDemo(Tyrannosaurus c)
        {
        
           // Put bunny ears on our T-Rex
           c.DressUp("Bunny Ears");

           // output reflects change in private field i.e he's too mad to wear anything else!
           c.DressUp("Party Hat");

           // now we sing to soothe the angry dino
           c.Sing();

           // the soothed dino is now ready to wear the party hat!
           c.DressUp("Party Hat");

           // let's sing again to soothe the dino once more
           c.Sing();

           // now we'll sing to him again -- but it won't have the same effect
           c.Sing();

        }
    
    }
}
