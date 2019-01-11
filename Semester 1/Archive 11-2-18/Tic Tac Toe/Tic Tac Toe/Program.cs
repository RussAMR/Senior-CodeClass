using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }
            Console.WriteLine("Type 1 for (3x3) type 2 for (4x4)");
            int UInp = int.Parse(Console.ReadLine());
            if(UInp == 1)
            {

            }
            int[,] MDA = new int[10, 5];

            for (int i = 0; i < MDA.GetLength(0); i++)
            {
                for (int j = 0; j < MDA.GetLength(1); j++)
                {
                    MDA[i, j] = i * j;
                }
            }
            drawBoard(board);

        }
        static void drawBoard(char[,] Board)
        {
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Console.Write(Board[i, j] + "\t");
                }
                Console.WriteLine();
            }


        }
        static void Processturn(char[,] Array, char Player)
        {

        }
        static void VerBoard(char[,] Board)
        {
            
        }
    }
}
