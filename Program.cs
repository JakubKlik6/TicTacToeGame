using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace completeMasterclass
{
    internal class TicTacToeGame
    {
        //the playfield
        static char[,] playField =
        {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'}
        };

        static void Main(string[] args)
        {
            int player = 2; //player 1 starts
            int userInput = 0;
            bool inputCorrect = true;

            //run code as long as program runs
            #region
            do
            {
                if (player == 2)
                {
                    player = 1;
                    EnterOorX(player, userInput);
                }

                else
                {
                    player = 2;
                    EnterOorX(player, userInput);
                }

                //board
                SetField();

                //winner checker
                WinnerChecker(player);

                //Test if player field is already taken
                #region
                do
                {
                    Console.Write("\nPlayer {0} : choose field! ", player);
                    try
                    {
                        userInput = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please enter a valid number from 1 - 9!");
                    }

                    if ((userInput == 1) && playField[0, 0] == '1')
                        inputCorrect = true;
                    else if ((userInput == 2) && playField[0, 1] == '2')
                        inputCorrect = true;
                    else if ((userInput == 3) && playField[0, 2] == '3')
                        inputCorrect = true;
                    else if ((userInput == 4) && playField[1, 0] == '4')
                        inputCorrect = true;
                    else if ((userInput == 5) && playField[1, 1] == '5')
                        inputCorrect = true;
                    else if ((userInput == 6) && playField[1, 2] == '6')
                        inputCorrect = true;
                    else if ((userInput == 7) && playField[2, 0] == '7')
                        inputCorrect = true;
                    else if ((userInput == 8) && playField[2, 1] == '8')
                        inputCorrect = true;
                    else if ((userInput == 9) && playField[2, 2] == '9')
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("Incorrect input");
                        inputCorrect = false;
                    }
                }
                while (!inputCorrect);
                #endregion
            }
            while (true);
            #endregion

            Console.Read();
        }


        //winner checker
        public static void WinnerChecker(int player)
        {
            if ((playField[0, 0] == playField[0, 1] && playField[0, 1] == playField[0, 2])
            || (playField[0, 1] == playField[1, 1] && playField[1, 1] == playField[2, 1])
            || (playField[0, 0] == playField[1, 1] && playField[1, 1] == playField[2, 2])
            || (playField[0, 2] == playField[1, 1] && playField[1, 1] == playField[2, 0]))
            {
                Console.WriteLine("Player {0} have won!", player);

                Console.WriteLine("Please press anu button to reset the game");
                Console.ReadKey();

                ResetGame();
            }
            else if (((playField[0, 0] == 'X') || (playField[0, 0] == 'O')) && ((playField[0, 1] == 'X') || (playField[0, 1] == 'O'))
                && ((playField[0, 2] == 'X') || (playField[0, 2] == 'O')) && ((playField[1, 0] == 'X') || (playField[1, 0] == 'O'))
                && ((playField[1, 1] == 'X') || (playField[1, 1] == 'O')) && ((playField[2, 0] == 'X') || (playField[2, 0] == 'O'))
                && ((playField[2, 1] == 'X') || (playField[2, 1] == 'O')) && ((playField[2, 2] == 'X') || (playField[2, 2] == 'O')))
            {
                Console.WriteLine("D R A W");

                Console.WriteLine("Please press anu button to reset the game");
                Console.ReadKey();

                ResetGame();
            }
        }


        //reset game
        public static void ResetGame()
        {
            char[,] playFieldInitial =
        {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'}
        };
            playField = playFieldInitial;
            SetField();
        }


        //board
        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("     |     |     ");
        }


        //player sign
        public static void EnterOorX(int player, int userInput)
        {
            char playerSign = ' ';

            if (player == 1)
                playerSign = 'X';
            else if (player == 2)
                playerSign = 'O';

            switch (userInput)
            {
                case 1:
                    playField[0, 0] = playerSign; break;
                case 2:
                    playField[0, 1] = playerSign; break;
                case 3:
                    playField[0, 2] = playerSign; break;
                case 4:
                    playField[1, 0] = playerSign; break;
                case 5:
                    playField[1, 1] = playerSign; break;
                case 6:
                    playField[1, 2] = playerSign; break;
                case 7:
                    playField[2, 0] = playerSign; break;
                case 8:
                    playField[2, 1] = playerSign; break;
                case 9:
                    playField[2, 2] = playerSign; break;
            }
        }
    }
}