using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Die
    {
        public static void RollDie()
        {
            int PlayerPossition = 0;

            Random random= new Random();
            int Roll_die = random.Next(1,7);

            Console.WriteLine(Roll_die);
        }
    }
}
