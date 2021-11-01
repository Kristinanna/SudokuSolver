using System;
using System.Collections.Generic;
using System.Linq;

namespace SudokuSolver
{
    class Program
    {


        static void Main(string[] args)
        {
               List<int> Solution = new List<int>();

            List<List<int>> board = new List<List<int>>();
            board.Add(new List<int>() { 5, 3, 0, 0, 7, 0, 0, 0, 0 });
            board.Add(new List<int>() { 6, 0, 0, 1, 9, 5, 0, 0, 0 });
            board.Add(new List<int>() { 0, 9, 8, 0, 0, 0, 0, 6, 0 });
             board.Add(new List<int>() { 8, 0, 0, 0, 6, 0, 0, 0, 3 });
             board.Add(new List<int>() { 4, 0, 0, 8, 0, 3, 0, 0, 1 });
             board.Add(new List<int>() { 7, 0, 0, 0, 2, 0, 0, 0, 6 });
             board.Add(new List<int>() { 0, 6, 0, 0, 0, 0, 2, 8, 0 });
             board.Add(new List<int>() { 0, 0, 0, 4, 1, 9, 0, 0, 5 });
             board.Add(new List<int>() { 0, 0, 0, 0, 8, 0, 0, 7, 9 });

            Console.WriteLine(board[0][0]);
            
            foreach (int str in Solution)
            {
                Console.Write(str + "");
            }

                  for (int i = 0; i < board.Count; i++)
                   {
                    for (int j = 0; j < board[i].Count; j++)
                    {
                        Console.WriteLine(board [i] [j]);
                    }

                Console.WriteLine("");
                    


                }
            }
        static List<int> Solve_Board(List<List<int>> board, int row, int col)
        {
            return null;
        }
        }
    }
