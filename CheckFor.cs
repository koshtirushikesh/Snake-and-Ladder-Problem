using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class CheckFor
    {
        public static void SnakeAndLadder()
        {
            int PlayerPossition = 0;

            Random random = new Random();

            int Roll_die = random.Next(1, 7);
            int Option = random.Next(3);

            Console.WriteLine(Roll_die);
            PlayerPossition += Roll_die;
            Console.WriteLine(PlayerPossition);

            if (Option == 0)
            {  
                PlayerPossition = PlayerPossition - Roll_die;
                Console.WriteLine("snake "+ PlayerPossition);
            }
            else if (Option == 1)
            {
                PlayerPossition = PlayerPossition + Roll_die;
                Console.WriteLine("ladder "+ PlayerPossition);
            }
            else
            {
                Console.WriteLine("no play "+ PlayerPossition);
            }


        }
    }
}
