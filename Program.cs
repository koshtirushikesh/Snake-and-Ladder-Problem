namespace SnakeAndLadder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Snake & Ladder Simulator");

            int PlayerPossition_1 = 0, PlayerPossition_2 = 0;


            Console.WriteLine("The Player has started from 0 possition");
            
            while(true)
            {
                 PlayerPossition_1 = Option.mPlayerPossition(PlayerPossition_1);
                Console.WriteLine("player 1 possition " + PlayerPossition_1);

                 PlayerPossition_2 = Option.mPlayerPossition(PlayerPossition_2);
                Console.WriteLine("player 2 possition " + PlayerPossition_2);
                if (PlayerPossition_1 == 100)
                {
                    Console.WriteLine("player 1 has won ");
                    break;
                }
                else if (PlayerPossition_2 == 100)
                {
                    Console.WriteLine("player 2 has won ");
                    break;
                }
            }

            
        }
    }
}