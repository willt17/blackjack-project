using System;

namespace blackjack_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Time to play blackjack" );
        }
        static int random2()
        {
            Random randomNumber= new Random();
            int number;
            number = randomNumber.Next( 1, 10 );
            return number;
        }
    }
}
