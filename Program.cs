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
                bjComputerTurnInit( ref player2Cards );
                Console.WriteLine( "You have " + player1Cards );
                Console.WriteLine( "The computer has " + player2Cards );
                playerDecision();
            }
        }
        static void bjPlayerTurnInit( ref int player1Cards )
        {
            int pCard1 = random2();
            int pCard2 = random2();
            player1Cards  = pCard1 + pCard2;  
        }
        static void bjComputerTurnInit( ref int player2Cards )
        {
            int cCard1 = random2();
            int cCard2 = random2();
            player2Cards = cCard1 + cCard2; 
        }
        static void playerDecision()
        {
            Console.WriteLine( "Press 1 to stand or 2 to hit" );
            string input = Console.ReadLine();
            int userInput = int.Parse( input );
            switch ( userInput )
            {
                case 1:
                    standFunction();
                    break;
                case 2:
                    hitFunction();
                    break;
                default:
                    wrongInput();
                    break;
            }
        }
        static void standFunction()
        {
            Console.WriteLine( "You chose to stand" );
        }
        static void hitFunction()
        {
            Console.WriteLine( "You chose to hit" );
        }
        static void wrongInput()
        {
            Console.WriteLine( "That input is not valid" );
        }
    }
}
