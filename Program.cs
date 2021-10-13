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
                playerDecision( ref player1Cards, ref player2Cards );
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
        static void playerDecision( ref int player1Cards, ref int player2Cards )
        {
            Console.WriteLine( "Press 1 to stand or 2 to hit" );
            string input = Console.ReadLine();
            int userInput = int.Parse( input );
            switch ( userInput )
            {
                case 1:
                    standFunction( ref player1Cards, ref player2Cards );
                    break;
                case 2:
                    hitFunction( ref player1Cards, ref player2Cards );
                    break;
                default:
                    wrongInput();
                    break;
            }
        }
        static void standFunction( ref int player1Cards, ref int player2Cards )
        {
            Console.WriteLine( "You chose to stand" );
            Console.WriteLine( "You still have " + player1Cards );
            computerLogic( ref player2Cards, ref player1Cards );
        }
        static void hitFunction( ref int player1Cards, ref int player2Cards )
        {
            Console.WriteLine( "You chose to hit" );
            int pAdd = random2();
            player1Cards = player1Cards + pAdd;
            Console.WriteLine( "You now have " + player1Cards );
            if ( player1Cards < 21 )
            {
                computerLogic( ref player2Cards, ref player1Cards );
            }
            else if ( player1Cards == 21 )
            {
                bjWin();
            }
            else
            {
                bjLose();
            }
   


        }
        static void wrongInput()
        {
            Console.WriteLine( "That input is not valid" );
        }
        static void computerLogic( ref int player2Cards, ref int player1Cards )
        {
            if ( player2Cards < 17 )
            {
                computerHit( ref player2Cards, ref player1Cards );
            }
            else
            {
                computerStand( ref player2Cards, ref player1Cards );
            }
        }
        static void computerHit( ref int player2Cards, ref int player1Cards )
        {
            Console.WriteLine( "The computer will hit" );
            int cAdd = random2();
            player2Cards = player2Cards + cAdd;
            Console.WriteLine( "The computer now has " + player2Cards );
            playerDecision( ref player1Cards, ref player2Cards );
        }
        static void computerStand( ref int player2Cards, ref int player1Cards )
        {
            Console.WriteLine( "The computer will stand at " + player2Cards );
            playerDecision(ref player1Cards, ref player2Cards );
        }
        static void bjWin()
        {
            Console.WriteLine( "You won this hand" );
        }
        static void bjLose()
        {
            Console.WriteLine( "You lost this hand" );
        }
    }
}
