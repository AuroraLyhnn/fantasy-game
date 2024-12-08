using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FantasyGame__1
{
    public class Wolf
    {
        public void Attack(string campOrWoods)
        {
            if (campOrWoods == "1")
            {
                Program.Print(Story.Wolf.CFWolfIntro);
                if (campOrWoods == "1")
                {
                    AttackCamp();
                }
                else
                {
                    AttackWoods();
                }
            }
        }

        public void AttackCamp()
        {
            if (Status.Inventory.Items.Contains("stick"))
            {
                Program.Print("");
            }
            else if (Status.Inventory.Items.Contains("spear"))
            {
                Program.Print("");
            }
            else
            {
                Program.Print("");
            }
        }

        public void AttackWoods()
        {
            //Program.Print(Story.Wolf.?); An intro of running into the wolf in the woods and its description
            //i want to put switch statements in the if else to give the player choices on how to flee or fight with the wolf
            if (Status.Inventory.Items.Contains("stick"))
            {
                Program.Print("");
            }
            else if (Status.Inventory.Items.Contains("spear"))
            {
                Program.Print("");
            }
            else
            {
                Program.Print("");
            }
        }

        // in wolfattack wil ik het healthsysteem meenemen, afhankelijk van hoe je de wolf behandeld kan hij je goed verwonden.
        // En dit kan verschillende scenarios triggeren afhankelijk van wat je al hebt meegemaakt voor je hem tegenkomt
        // wait what was that                    
        // if in the scenario the character gets wounded  Status.Health.AddWound("bitewound"); for example

    }
}
