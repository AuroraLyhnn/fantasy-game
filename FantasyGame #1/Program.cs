using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Text;

namespace FantasyGame__1
{

    class Program
    {
        static string campOrWoods;
        static string stickChoice;
        
        static void Main(string[] args)
        {
            //opening
            Print(Beginning.Intro1);
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
                    Print("please choose 1 or 2 ♥");
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
                        Print("");
                        Print("Since you havent heard much noises yet and youre pretty tired from the stress today|");
                        FallAsleep();
                        break;

                    case "2":
                        Print("Since the cozyness of the fire only gives a shallow feeling of safety,|\nyou dont want to sit and do nothing for much longer.|");
                        LookAround();
                        break;

                    case "3":
                        Print("These berries are pretty tasteless and have a weird feel. Almost as if they turn to smoke in your mouth");
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
        static void FallAsleep()
        {
            Print(Scenario.FallAsleep);
            var wolf = new Wolf();
            wolf.Attack(campOrWoods);
        }

        static void LookAround()
        {
            Print("You look around you to see what is out there.|\nEven though its very dark you can destinguish the shape of a pretty big fallen branch closeby.\nYou decide to walk over there and grab it.\n|");
            Storage.Inventory.AddItem("stick");
            if (campOrWoods == "1")
            {
                Print("What are you gonna do with this big stick?\n\n|1.  Keep it as a stick\n2.  Use the wood to keep the fire going\n3.  Sharpen the stick with your knife to use it as a spear\n");
                stickChoice = Console.ReadLine();
                Print("");
                if (stickChoice == "1")
                {
                    Print("You shove the stick between your belt to keep it close, and walk back to the campfire.|");
                    
                }
                else if (stickChoice == "2")
                {
                    Print(Scenario.StickSc2);
                }
                else if (stickChoice == "3")
                {
                    Print(Scenario.StickSc3);               
                }
                else
                {
                    Print("Please choose between 1, 2 or 3 ♥");
                }
            }
            else
            {
                Print("What are you gonna do with this big stick?\n\n|1.  Keep it as a stick\n2.  Sharpen the stick with your knife to use it as a spear\n");
                stickChoice = Console.ReadLine();
                if (stickChoice == "1")
                {
                    Print("");
                }
                else if (stickChoice == "2")
                {
                    Print("");
                }
                else
                {
                    Print("Please choose between 1 or 2 ♥");
                }
            }
        }

        static void EatBerries()
        {
            // can heal one status condition in Healthstruggles (any status condition? like even grow back a bitten off leg? Think about this..)
        }

        static void WolfAttack()
        {
            if (campOrWoods == "1")
            {
                if (Storage.Inventory.Items.Contains("stick"))
                {
                    Print("");
                }
                else if (Storage.Inventory.Items.Contains("spear"))
                {
                    Print("");
                }
                else
                {
                    Print("");
                }
            }
            else
            {
                if (Storage.Inventory.Items.Contains("stick"))
                {
                    Print("");
                }
                else if (Storage.Inventory.Items.Contains("spear"))
                {
                    Print("");
                }
                else
                {
                    Print("");
                }
            }
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