﻿using ConsoleChess.Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess
{
    internal class Screen
    {
        public static void PrintBoard(ChessBoard board)
        {
            for (int i = 0; i < board.Lines; i++)
            {
                for(int j = 0; j < board.Columns; j++)
                {
                    if(board.part(i, j) == null)
                    {
                        Console.Write("- ");
                    } else
                    {
                        Console.Write(board.part(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
