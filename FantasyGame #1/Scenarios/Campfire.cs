using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyGame__1.Scenarios
{
    public class Campfire
    {
        public void Fire()
        {
            if (Status.Inventory.Items.Contains("firewood"))
            {
                Program.Print("You throw the broken stick on the fire to keep it going. But as soon as the wood touches the fire, a giant sparkly cloud shoots op into the sky.");
                
            }

        }
    }
}
