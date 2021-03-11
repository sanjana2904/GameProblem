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
            for (int day = 0; day <= 20; day++)
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

               Console.WriteLine("day is: " + day);
                
            }
            
        }
    }
}
