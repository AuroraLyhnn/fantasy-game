using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyGame__1
{
    public class LookAround
    {
        static string stickChoice;

        public void Look(string campOrWoods)
                    
        {
            Program.Print("You look around you to see what is out there.|\nEven though its very dark you can destinguish the shape of a pretty big fallen branch closeby.\nYou decide to walk over there and grab it.\n|");
            Storage.Inventory.AddItem("stick");
            if (campOrWoods == "1")
            {
                Program.Print("What are you gonna do with this big stick?\n\n|1.  Keep it as a stick\n2.  Use the wood to keep the fire going\n3.  Sharpen the stick with your knife to use it as a spear\n");
                stickChoice = Console.ReadLine();
                Program.Print("");
                if (stickChoice == "1")
                {
                    Program.Print("You shove the stick between your belt to keep it close, and walk back to the campfire.|");

                }
                else if (stickChoice == "2")
                {
                    Program.Print(Scenario.StickSc2);
                }
                else if (stickChoice == "3")
                {
                    Program.Print(Scenario.StickSc3);
                }
                else
                {
                    Program.Print("Please choose between 1, 2 or 3 ♥");
                }
            }
            else
            {
                Program.Print("What are you gonna do with the stick?\n\n|1.  Keep it as a stick\n2.  Sharpen the stick with your knife to use it as a spear\n");
                stickChoice = Console.ReadLine();
                if (stickChoice == "1")
                {
                    Program.Print("");
                }
                else if (stickChoice == "2")
                {
                    Program.Print("");
                }
                else
                {
                    Program.Print("Please choose between 1 or 2 ♥");
                }
            }
        }

    }
}
