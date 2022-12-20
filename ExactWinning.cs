using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class ExactWinning
    {
        public static void Exact_Winning()
        {
            int PlayerPossition = 0;

            Random random = new Random();

            while (PlayerPossition < 100)
            {
                int Roll_die = random.Next(1, 7);
                int Option = random.Next(3);

                Console.WriteLine("die role");

                PlayerPossition += Roll_die;

                if (Option == 0)
                {
                    PlayerPossition = PlayerPossition - Roll_die;
                    Console.WriteLine("snake " + PlayerPossition);
                }
                else if (Option == 1)
                {
                    PlayerPossition = PlayerPossition + Roll_die;
                    Console.WriteLine("ladder " + PlayerPossition);
                }
                else
                {
                    Console.WriteLine("no play " + PlayerPossition);
                }

                if (PlayerPossition > 100) { PlayerPossition = PlayerPossition - Roll_die; }
                else if (PlayerPossition < 0) { PlayerPossition = 0; }
                else if (PlayerPossition == 100) { Console.WriteLine("player has won"); break; }

            }

        }

    }   
}

