using System;
using System.Collections.Generic;
using System.Linq;
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
                if (Storage.Inventory.Items.Contains("stick"))
                {
                    Program.Print("");
                }
                else if (Storage.Inventory.Items.Contains("spear"))
                {
                    Program.Print("");
                }
                else
                {
                    Program.Print("");
                }
            }
            else
            {
                if (Storage.Inventory.Items.Contains("stick"))
                {
                    Program.Print("");
                }
                else if (Storage.Inventory.Items.Contains("spear"))
                {
                    Program.Print("");
                }
                else
                {
                    Program.Print("");
                }
            }
        }
        // in wolfattack wil ik het healthsysteem meenemen, afhankelijk van hoe je de wolf behandeld kan hij je goed verwonden.
        // En dit kan verschillende scenarios triggeren afhankelijk van wat je al hebt meegemaakt voor je hem tegenkomt
    }
}
