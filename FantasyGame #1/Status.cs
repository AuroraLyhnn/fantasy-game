using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyGame__1
{
    public class Status
    {
        public static class Inventory
        {
            public static List<string> Items { get; set; }

            static Inventory()
            {
                Items = new List<string>();
                Items.Add("berries");
                Items.Add("small knife");
            }

            public static void ShowInventory()
            {
                Console.WriteLine("Inventory:");
                foreach (var item in Items)
                {
                    Console.WriteLine(item);
                }
            }

            public static void AddItem(string item)
            {
                Items.Add(item);
            }

            public static void RemoveItem(string item) 
            { 
                Items.Remove(item); 
            }
        }

        public static class Health  
        {
            public static List<string> Struggles { get; set; }

            static Health()
            {
                Struggles = new List<string>();
                Struggles.Add("default");
                Struggles.Add("");
            }

            public static void ShowHealth()
            {
                Console.WriteLine("What you're dealing with:");
                foreach (var wound in Struggles)
                {
                    Console.WriteLine(wound);
                }
            }

            public static void AddWound(string wound)
            {
                Struggles.Add(wound);
            }
        }

    }
}
