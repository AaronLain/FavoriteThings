using FavoriteThings.Dinosaurs;
using System;


namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
           
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


            do
            {
                terrance.DressUp("Bunny Ears");

                // output reflects change in private field i.e he's too mad to wear anything else!
                terrance.DressUp("Party Hat");

                // now we sing to soothe the angry dino
                terrance.Sing();

                // the soothed dino is now ready to wear the pary hat!
                terrance.DressUp("Party Hat");

                // let's sing again to sooth the dino once more
                terrance.Sing();

                // now we'll sing to him again -- but it won't have the same effect
                terrance.Sing();

                Console.WriteLine("Continue?");

                var input = Console.ReadLine();

                var cont = input?.ToLower();

                if ((cont == "y") || (cont == "n"))
                    break;
            } while (true);

            do
            {
                chauncey.DressUp("Bunny Ears");

                // output reflects change in private field i.e he's too mad to wear anything else!
                chauncey.DressUp("Party Hat");

                // now we sing to soothe the angry dino
                chauncey.Sing();

                // the soothed dino is now ready to wear the pary hat!
                chauncey.DressUp("Party Hat");

                // let's sing again to sooth the dino once more
                chauncey.Sing();

                // now we'll sing to him again -- but it won't have the same effect
                chauncey.Sing();

                Console.WriteLine("Continue?");

                var input = Console.ReadLine();

                var cont = input?.ToLower();

                if ((cont == "y") || (cont == "n"))
                    break;
            } while (true);

            do
            {
                bill.Insult("Butthead");

                // output reflects change in private field i.e he's too mad to wear anything else!
                bill.Insult("Buttface");

                // now we sing to soothe the angry dino
                bill.Sing();

                // the soothed dino is now ready to wear the pary hat!
                bill.Insult("ButtButt");

                // let's sing again to sooth the dino once more
                bill.Sing();

                // now we'll sing to him again -- but it won't have the same effect
                bill.Sing();

                Console.WriteLine("Continue?");

                var input = Console.ReadLine();

                var cont = input?.ToLower();

                if ((cont == "y") || (cont == "n"))
                    break;
            } while (true);

            do
            {
                steph.Insult("Butthead");

                // output reflects change in private field i.e he's too mad to wear anything else!
                steph.Insult("Buttface");

                // now we sing to soothe the angry dino
                steph.Sing();

                // the soothed dino is now ready to wear the pary hat!
                steph.Insult("ButtButt");

                // let's sing again to sooth the dino once more
                steph.Sing();

                // now we'll sing to him again -- but it won't have the same effect
                steph.Sing();

                Console.WriteLine("Continue?");

                var input = Console.ReadLine();

                var cont = input?.ToLower();

                if ((cont == "y") || (cont == "n"))
                    break;
            } while (true) ;

            do
            {
                melvin.Argue(Troodon.EconomicTheories.Agrarianism);

                // output reflects change in private field i.e he's too mad to wear anything else!
                melvin.Argue(Troodon.EconomicTheories.Feudalism);

                // now we sing to soothe the angry dino
                melvin.Sing();

                // the soothed dino is now ready to wear the pary hat!
                melvin.Argue(Troodon.EconomicTheories.Feudalism);

                // let's sing again to sooth the dino once more
                melvin.Sing();

                // now we'll sing to him again -- but it won't have the same effect
                melvin.Sing();

                Console.WriteLine("Continue?");

                var input = Console.ReadLine();

                var cont = input?.ToLower();

                if ((cont == "y") || (cont == "n"))
                    break;
            } while (true);

            do
            {
                derek.Argue(Troodon.EconomicTheories.Capitalism);

                // output reflects change in private field i.e he's too mad to wear anything else!
                derek.Argue(Troodon.EconomicTheories.Socialism);

                // now we sing to soothe the angry dino
                derek.Sing();

                // the soothed dino is now ready to wear the pary hat!
                derek.Argue(Troodon.EconomicTheories.Socialism);

                // let's sing again to sooth the dino once more
                derek.Sing();

                // now we'll sing to him again -- but it won't have the same effect
                derek.Sing();

                Console.WriteLine("Continue?");

                var input = Console.ReadLine();

                var cont = input?.ToLower();

                if ((cont == "y") || (cont == "n"))
                    break;
            } while (true);

            do
            {
                charlotte.Paint("Red");

                // output reflects change in private field i.e he's too mad to wear anything else!
                charlotte.Paint("Green");

                // now we sing to soothe the angry dino
                charlotte.Sing();

                // the soothed dino is now ready to wear the pary hat!
                charlotte.Paint("Red");

                // let's sing again to sooth the dino once more
                charlotte.Sing();

                // now we'll sing to him again -- but it won't have the same effect
                charlotte.Sing();

                Console.WriteLine("Continue?");

                var input = Console.ReadLine();

                var cont = input?.ToLower();

                if ((cont == "y") || (cont == "n"))
                    break;
            } while (true);

            do
            {
                ashley.Paint("Blue");

                // output reflects change in private field i.e he's too mad to wear anything else!
                ashley.Paint("Pink");

                // now we sing to soothe the angry dino
                ashley.Sing();

                // the soothed dino is now ready to wear the pary hat!
                ashley.Paint("Pink");

                // let's sing again to sooth the dino once more
                ashley.Sing();

                // now we'll sing to him again -- but it won't have the same effect
                ashley.Sing();

                Console.WriteLine("Continue?");

                var input = Console.ReadLine();

                var cont = input?.ToLower();

                if ((cont == "y") || (cont == "n"))
                    break;
            } while (true);

        }
    }
}
