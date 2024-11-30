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
            Program.Print(Story.Stick.Find);
            Status.Inventory.AddItem("stick");
            if (campOrWoods == "1")
            {
                Program.Print(Story.Stick.Choices);
                stickChoice = Console.ReadLine();
                Program.Print("");
                if (stickChoice == "1")
                {
                    Program.Print(Story.Stick.CFStick1);
                }
                else if (stickChoice == "2")
                {
                    Program.Print(Story.Stick.CFStick2);
                }
                else if (stickChoice == "3")
                {
                    Program.Print(Story.Stick.CFStick3);
                }
                else
                {
                    Program.Print(Story.Error.Options3);
                }
            }
            else
            {
                Program.Print(Story.Stick.Choices);
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
                    Program.Print(Story.Error.Options2);
                }
            }
        }
    }
}
