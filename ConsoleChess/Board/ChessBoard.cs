﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess.Board
{
    internal class ChessBoard
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Part[,] Parts;

        public ChessBoard(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            Parts = new Part[Lines, Columns];
        }

        public Part part(int lines, int columns)
        {
            return Parts[lines, columns];
        }

        //posição no tabuleiro
       public Part part(Position pos)
        {
            return Parts[pos.Line, pos.Column];
        }

        //testar se existe uma peça em uma posição
        public bool IsPart(Position pos)
        {
            ValidatePosition(pos);
            return part(pos) != null;
        }

        //colocar peças
        public void AddPart(Part p, Position pos)
        {
            if(IsPart(pos))
            {
                throw new ChessBoardExeption("Já existe uma peça nessa posição");
            }
            Parts[pos.Line, pos.Column] = p;
            p.Position = pos;
        }
        public Part RemovePart(Position pos)
        {
            if (!IsPart(pos)) return null; 

            Part aux = part(pos);
            aux.Position = null;
            Parts[pos.Line, pos.Column] = null;
            return aux;
        }

        //testar se posição é valida
        public bool ValidPosition(Position pos)
        {
            if(pos.Line < 0 || pos.Line >= Lines || pos.Column < 0 || pos.Column >= Columns)
            {
                return false; //posição não é valida
            }
            return true;
        }

        public void ValidatePosition(Position pos)
        {
            if(!ValidPosition(pos)) {
                throw new ChessBoardExeption("Posição inváçida");
            }
        }
    }
}
