using FavoriteThings.Dinosaurs;
using System;


namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            // T-Rex -- name and age
            var terrance = new Tyrannosaurus("Terrance", 67000000);
            var chauncey = new Tyrannosaurus("Chauncey", 66000345);

            // Charonosaur -- name and age
            var bill = new Charonosaurus("Bill", 65000001);
            var steph = new Charonosaurus("Stephanie", 65900231);

            //Troodon -- name and age
            var melvin = new Troodon("Melvin", 66000832);
            var derek = new Troodon("Derek", 67102030);

            // Allosaurus -- name, age, and color
            var ashley = new Allosaurus("Ashley", 146001230, "Teal");
            var charlotte = new Allosaurus("Charlotte", 148090123, "Puce");

            // Console App Logic
            Console.WriteLine("Pick a dino to demo:");
            Console.WriteLine("1: Tyrannosaurus");
            Console.WriteLine("2: Charonosaurus");
            Console.WriteLine("3: Troodon");
            Console.WriteLine("4: Allosaurus");

            input = Console.ReadLine();
                
            if (input != "exit" || input != "")
            {
                switch (input)
                {
                    case "1":
                        terrance.TDemo(terrance);
                        chauncey.TDemo(chauncey);
                        break;
                    case "2":
                        bill.CDemo(bill);
                        steph.CDemo(steph);
                        break;
                    case "3":
                        melvin.TrDemo(melvin);
                        derek.TrDemo(derek);
                        break;
                    case "4":
                        ashley.ADemo(ashley);
                        charlotte.ADemo(charlotte);
                        break;
                    default:
                        Console.WriteLine("You have to pick a number between 1 - 4!");
                        break;

                }
            }
        }
    }
}
