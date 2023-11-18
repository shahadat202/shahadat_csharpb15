using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TaskFour_TicTacToe
{
    public class TicTacToe
    {
        private char[] board;
        private int playerTurn;

        public TicTacToe()
        {
            board = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            playerTurn = 1;
        }

        public void PlayGame()
        {
            int choice;
            bool validMove;

            do
            {
                DrawBoard();
                Console.WriteLine($"Player {playerTurn}'s turn. Enter your move (1-9): ");
                validMove = int.TryParse(Console.ReadLine(), out choice);

                if (validMove && choice >= 1 && choice <= 9 && board[choice - 1] != 'X' && board[choice - 1] != 'O')
                {
                    char symbol = (playerTurn == 1) ? 'X' : 'O';
                    board[choice - 1] = symbol;
                    playerTurn = (playerTurn == 1) ? 2 : 1;
                }
                else
                {
                    Console.WriteLine("Invalid move. Please try again.");
                }

            } while (!IsGameOver());

            DrawBoard();
            int winner = GetWinner();

            if (winner == 0)
                Console.WriteLine("It's a draw!");
            else
                Console.WriteLine($"Player {winner} wins!");

            Console.WriteLine("Game Over!");
        }

        private void DrawBoard()
        {
            Console.Clear();
            Console.WriteLine("Tic Tac Toe");
            Console.WriteLine($"Player 1: X Player 2: O\n");
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
        }

        private bool IsGameOver()
        {
            return GetWinner() != -1 || Array.TrueForAll(board, c => c == 'X' || c == 'O');
        }

        private int GetWinner()
        {
            // Check rows, columns and diagona for a win
            for (int i = 0; i < 3; i++)
            {
                if (board[i] == board[i + 3] && board[i] == board[i + 6])
                    return (board[i] == 'X') ? 1 : 2;

                if (board[i * 3] == board[i * 3 + 1] && board[i * 3] == board[i * 3 + 2])
                    return (board[i * 3] == 'X') ? 1 : 2;
            }

            if (board[0] == board[4] && board[0] == board[8])
                return (board[0] == 'X') ? 1 : 2;

            if (board[2] == board[4] && board[2] == board[6])
                return (board[2] == 'X') ? 1 : 2;

            return -1; // No winner yet;
        }
    }
}