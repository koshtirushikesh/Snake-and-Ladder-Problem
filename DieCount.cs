using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
     public class DieCount
    {
        public static void DieCountTillWin()
        {
            int PlayerPossition = 0;
            int dieCount = 0;

            Random random = new Random();

            while (PlayerPossition < 120)
            {
                int Roll_die = random.Next(1, 7);
                dieCount++;
                int Option = random.Next(3);

                PlayerPossition += Roll_die;
                Console.WriteLine("die roll: " + PlayerPossition);

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
                if (PlayerPossition < 0) { PlayerPossition = 0; }
                if (PlayerPossition == 100) { Console.WriteLine("player has won"); break; }
                       
                 
            }
            Console.WriteLine("die cout :" + dieCount);
        }
        
    }
}
