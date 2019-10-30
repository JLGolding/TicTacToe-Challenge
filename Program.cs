using System;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {                                           //0    1    2    3    4    5    6    7    8    9
        static string[] board = new string[10] { ".", ".", ".", ".", ".", ".", ".", ".", ".", "." }; //initial set up on single board for game
        static bool gameOver = false;
        static bool validSelection;//flag for keeping the player in a loop until the make a valid position selection
        static int playerNumber = 1;
        static int turnNumber = 0;
        static bool player1Win = false;
        static bool player2Win = false;


        public static void Main()//main game loop
        {

           
            Console.WriteLine("Lets play a game of tic tac toe");

            while (gameOver == false)
            {
                string pIn;

                DisplayBoard();//draws the current board
                PlayerMessage(playerNumber);//prompt for the players
                validSelection = false;//flag to keep players inputing until a valid entry
                while (validSelection == false)
                {
                    pIn = Console.ReadLine();//read an input from player
                    PlayerSelectionCheck(pIn);//Check valid selection

                }
                if (turnNumber >= 4)// Check for win - possibly don't need to check each turn but could be an optimisation 
                {
                    player1Win = CheckPlayerOneWin();//win conditions for player 1
                    player2Win = CheckPlayerTwoWin();//win conditions for player 2
                }

                if (player1Win == true) {
                    Console.WriteLine("Player 1 Wins!!!!");
                    DisplayBoard();
                    gameOver = true;
                }

                
                if (player2Win == true) {
                    Console.WriteLine("Player 2 Wins!!!!");
                    DisplayBoard();
                    gameOver = true;
                }

                if (turnNumber >= 9 && player1Win == false && player2Win == false ) /* board is full and neither player 1 or plaer 2 has won */{
                    ResultDraw();
                }

                if (gameOver == true)//don't want the game to exit the loop unless told to quit
                {
                    PlayAgain();//asks players if the want to play again
                }

            }
            

        }

        static void DisplayBoard()
        {//draws the board
            Console.WriteLine("Here's the board");

            Console.WriteLine(board[1]  + board[2] + board[3]);//top row
           
            Console.WriteLine(board[4]  + board[5] + board[6]);//second row
            
            Console.WriteLine(board[7]  + board[8] + board[9]);//third row
        }

        static void PlayerMessage(int playerNumber)
        {
            Console.WriteLine("Player " + playerNumber + " make a selection 1-9, press q to quit.");//tells which player to make a move
        }

        static void PlayerSelectionCheck(string input)
        {
            int playerSelection;

            if (input == "1" || input == "2" || input == "3" ||//check input is a number between 1 and 9
                input == "4" || input == "5" || input == "6" ||
                input == "7" || input == "8" || input == "9")
            {
                playerSelection = Convert.ToInt32(input);//convert string input to int

                if (board[playerSelection] == ".") //check that position does not contain an X or O
                {
                    if (playerNumber == 1)
                    {

                        board[playerSelection] = "X";//valid player 1 selection, place X
                        playerNumber++;//change to player 2 turn

                    }
                    else
                    {//Player 2 turn 
                        board[playerSelection] = "O";//valid player 2 selection, place O
                        playerNumber--;//change to player 1 turn
                    }

                    validSelection = true;//flag to get out of loop
                    turnNumber++;//end Player turn, increase turns taken

                }
                else
                {
                    Console.WriteLine("Sorry that spot is already taken, pick again");//Error message
                }

            }
            else if (input == "q" || input == "Q")
            {
                Console.WriteLine("Quit Requested");
                //gameOver = true;
                 //Task Task.Delay(500); TODO add a time delay before exiting
                Environment.Exit(0);//quit the game
            }
            else
            {
                Console.WriteLine("Uh Oh that selection is unavailable");//error message for non number input
                Console.WriteLine("Please pick again");//user prompt

            }



        }

        private static void ResultDraw()
        {
            Console.WriteLine("It's a draw!!");
            DisplayBoard();
            gameOver = true;
        }

        static bool CheckPlayerOneWin()
        {
            
            
                if (board[1] == board[2] && board[2] == board[3] && board[3] == "X")/*horizontal win*/
                {
                    
                    return true;
                }
                else if (board[4] == board[5] && board[5] == board[6] && board[6] == "X")/*horizontal win*/
                {
                    
                    return true;
                }
                else if (board[7] == board[8] && board[8] == board[9] && board[9] == "X")/*horizontal win*/
                {
                    
                    return true;
                }
                else if (board[1] == board[4] && board[4] == board[7] && board[7] == "X")/*vertical win*/
                {
                    
                    return true;
                }
                else if (board[2] == board[5] && board[5] == board[8] && board[8] == "X") /*vertical win*/
                {
                    
                    return true;
                }
                else if (board[3] == board[6] && board[6] == board[9] && board[9] == "X")/*vertical win*/
                {
                    
                    return true;
                }
                else if (board[1] == board[5] && board[5] == board[9] && board[9] == "X")/*diagonal win*/
                {
                    
                    return true;
                }
                else if (board[3] == board[5] && board[5] == board[7] && board[7] == "X")/*diagonal win*/
                {
                    
                    return true;
                }
                else
                {
                    return false;
                }

                                       
        }

        static bool CheckPlayerTwoWin()
        {
            
            
                if (board[1] == board[2] && board[2] == board[3] && board[3] == "O"/*horizontal win*/
                )
                {
                    
                    return true;
                }
                else if (board[4] == board[5] && board[5] == board[6] && board[6] == "O")/*horizontal win*/
                {
                    
                    return true;
                }
                else if (board[7] == board[8] && board[8] == board[9] && board[9] == "O")/*horizontal win*/
                {
                    
                    return true;
                }
                else if (board[1] == board[4] && board[4] == board[7] && board[7] == "O")/*vertical win*/
                {
                    
                    return true;
                }
                else if (board[2] == board[5] && board[5] == board[8] && board[8] == "O") /*vertical win*/
                {
                    
                    return true;
                }
                else if (board[3] == board[6] && board[6] == board[9] && board[9] == "O")/*vertical win*/
                {
                    
                    return true;
                }
                else if (board[1] == board[5] && board[5] == board[9] && board[9] == "O")/*diagonal win*/
                {
                    
                    return true;
                }
                else if (board[3] == board[5] && board[5] == board[7] && board[7] == "O")/*diagonal win*/
            {
                    
                    return true;
                }
                else
                {
                    return false;
                }
            
        }

      static void PlayAgain() {
            string input;
            Console.WriteLine("Do you want to play again? y/n");
            input = Console.ReadLine();

            if (input == "y" || input == "Y")
            {
                Reset();
            }
            else if (input == "n" || input == "N")
            {
                Environment.Exit(0);
            }
            else { 
                Console.WriteLine("Please press y or n"); 
            }
        }

        static void Reset() {
            gameOver = false;
            for (int i = 0; i < 10; i++) {
                board[i] = ".";
            }
            
            playerNumber = 1;
            turnNumber = 0;
            player1Win = false;
            player2Win = false;
        }
    }
}
    
    
    
    
    

    

