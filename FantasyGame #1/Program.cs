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
            Print(Story.General.Intro2);
            Console.WriteLine();

            //de keuze voor kamp of bos
            while (true)
            {
                campOrWoods = Console.ReadLine();
                Console.WriteLine();

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

            Print(Story.Camp.CFStart);

            while (true)
            {
                string cfStep1 = Console.ReadLine();
                Console.WriteLine();
                switch (cfStep1)
                {
                    case "1":
                        Print(Story.Camp.Rest);
                        Print(Story.Events.Sleep);
                        var wolf = new Wolf();
                        wolf.Attack(campOrWoods);
                        break;

                    case "2":
                        Print(Story.Camp.Look);
                        var lookAround = new LookAround();
                        lookAround.Look(campOrWoods);
                        break;

                    case "3":
                        var berries = new Berries();
                        berries.EatBerries(campOrWoods);
                        break;

                    default:
                        Print(Story.Error.Options3);
                        break;
                }
            }
        }

        //scenario 2: ga het bos in
        static void IntoTheWoods()
        {
            Print(Story.Woods.WStart);
        }

        //For the printing speed
        public static void Print(string text, int speed = 0, int longPauseSpeed = 0) //20, 400
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