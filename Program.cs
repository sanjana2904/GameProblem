using System;

namespace GameProblem
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int cash = 100;
            int bet = 1;

            int winPercent = 150;
            int lossPercent = 50;

            while (cash <= winPercent && cash >= lossPercent)
            {
                Random random = new Random();
                int check = random.Next(0, 2);
                if (check == bet)
                {
                    Console.WriteLine("win");
                    cash++;
                }
                else
                {
                    Console.WriteLine("loose");
                        cash--;
                }

                Console.WriteLine("cash is: " + cash);
            }
            
        }
    }
}
