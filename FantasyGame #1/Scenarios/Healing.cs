using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyGame__1
{
    public class Berries
    {
        public void EatBerries(string campOrWoods)
        {
            if (campOrWoods == "1")
            {
                if (Status.Health.Struggles.Contains("healthy"))
                {
                    Program.Print(Story.Healing.Eat);
                }
            }

            else
            {
                if (Status.Health.Struggles.Contains("healthy"))
                {
                    Program.Print(Story.Healing.Eat);
                }
            }
        }
    }
}
