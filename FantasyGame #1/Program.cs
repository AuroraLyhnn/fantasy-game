using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Text;

namespace FantasyGame__1
{

    class Program
    {
        static string campOrWoods;
       
        static void Main(string[] args)
        {
            //opening
            Print(Story.General.GameIntro);
            Console.ReadLine();
            Print(Beginning.Intro2);

            //de keuze voor kamp of bos
            while (true)
            {
                campOrWoods = Console.ReadLine();

                if (campOrWoods == "1")
                {
                    AtTheCampfire();
                }
                else if (campOrWoods == "2")
                {
                    IntoTheWoods();
                }
                else
                {
                    Print(Story.Error.Options2);
                }
            }
        }

        //scenario 1: blijf bij het kampvuur
        static void AtTheCampfire()
        {

            Print(CFStory.CFstart);

            while (true)
            {
                string cfStep1 = Console.ReadLine();
                switch (cfStep1)
                {
                    case "1":
                        Print("\nSince you havent heard much noises yet and youre pretty tired from the stress today|");
                        Print(Story.Events.Sleep);
                        var wolf = new Wolf();
                        wolf.Attack(campOrWoods);

                        break;

                    case "2":
                        Print("\nSince the cozyness of the fire only gives a shallow feeling of safety,|\nyou dont want to sit and do nothing for much longer.|");
                        var lookAround = new LookAround();
                        lookAround.Look(campOrWoods);
                        break;

                    case "3":
                        Print("\nThese berries are pretty tasteless and have a weird feel. Almost as if they turn to smoke in your mouth");
                        EatBerries();
                        break;
                }
            }
        }

        //scenario 2: ga het bos in
        static void IntoTheWoods()
        {
            Print(WStory.Wstart);
        }


        //// classes for scenarios that can happen at different times
        static void EatBerries()
        {
            // can heal one status condition in Healthstruggles (any status condition? like even grow back a bitten off leg? Think about this..)
        }

        
        
        public static void Print(string text, int speed = 20, int longPauseSpeed = 400)
        {
            string[] parts = text.Split('|');

            foreach (var part in parts)
            {
                foreach (char c in part)
                {
                    Console.Write(c);
                    System.Threading.Thread.Sleep(speed);
                }

                if (part != parts.Last())
                {
                    System.Threading.Thread.Sleep(longPauseSpeed);
                }
            }
            Console.WriteLine();
        }
    }
}