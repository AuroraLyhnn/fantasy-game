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
            if (campOrWoods == "1")
            {
                LookCamp();
            }
            else
            {
                LookWoods();
            }
        }

        public void LookCamp()
        {
            Program.Print(Story.Stick.CFChoices);
            var validChoice = false;
            while(!validChoice)
            {
                validChoice = true;
                stickChoice = Console.ReadLine();
                Program.Print("");
                if (stickChoice == "1")
                {
                    Program.Print(Story.Stick.CFStick1);
                    Status.Inventory.AddItem("stick");
                }
                else if (stickChoice == "2")
                {
                    Program.Print(Story.Stick.CFStick2);
                    Status.Inventory.AddItem("firewood");
                }
                else if (stickChoice == "3")
                {

                    Program.Print(Story.Stick.CFStick3);
                    Status.Inventory.AddItem("spear");

                }
                else
                {
                    Program.Print(Story.Error.Options3);
                    validChoice = false;
                }
            }
        }

        public void LookWoods()
        {
            var validChoice = false;
            while (!validChoice)
            {
                validChoice = true;
                Program.Print(Story.Stick.CFChoices);
                stickChoice = Console.ReadLine();
                if (stickChoice == "1")
                {
                    Program.Print("");
                    Status.Inventory.AddItem("stick");

                }
                else if (stickChoice == "2")
                {
                    Program.Print("");
                    Status.Inventory.AddItem("spear");
                }
                else
                {
                    Program.Print(Story.Error.Options2);
                    validChoice = false;
                }
            }
        }
    }
}
