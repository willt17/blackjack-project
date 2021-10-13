using System;

namespace blackjack_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Time to play blackjack" );
            blackjackGame();
        }
        static int random2()
        {
            Random randomNumber= new Random();
            int number;
            number = randomNumber.Next( 1, 10 );
            return number;
        }
        static void blackjackGame()
        {
            int player1Cards = 0;
            int player2Cards = 0;
            if ( player1Cards < 21 && player2Cards < 21 )
            {
                bjPlayerTurnInit( ref player1Cards );
            }
        }
        static void bjPlayerTurnInit( ref int player1Cards )
        {
            int pCard1 = random2();
            int pCard2 = random2();
            int pHand = pCard1 + pCard2;
            Console.WriteLine( pHand );
        }
    }
}
