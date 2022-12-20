using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class TilPossition100
    {
        public static void TillThe100()
        {
            int PlayerPossition = 0;

            Random random = new Random();
            
            while (PlayerPossition < 100)
            {
                int Roll_die = random.Next(1, 7);
                int Option = random.Next(3);

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

                if (PlayerPossition > 100) PlayerPossition -= Roll_die;
                if (PlayerPossition < 0) PlayerPossition = 0;
                if (PlayerPossition == 100) Console.WriteLine("player has won");
                
            }

        }
    }
}
