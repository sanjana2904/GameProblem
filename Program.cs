using System;

namespace GameProblem
{
    class Program
    {
        int cash = 100;
        int bet = 1;

        static void Main(string[] args)
        {

            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == bet)
            {
                Console.WriteLine("win")
            }
            else
            {
                Console.WriteLine("loose")
            }
            Console.WriteLine("welcome to game Problem");
        }
    }
}
