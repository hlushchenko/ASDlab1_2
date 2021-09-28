using System;
using System.Collections.Generic;

namespace AsdLab1Console
{
    public class ChessBoard
    {
        private byte[] _rows;

        public List<ChessBoard> PossibleMoves => _possibleMoves ??= GeneratePossibleMoves();
        public byte NumberOfConflicts { get; }

        private List<ChessBoard> _possibleMoves;

        public ChessBoard(byte[] state = null)
        {
            _rows = state ?? GenerateRandom();
            NumberOfConflicts = GenerateNumberOfConflicts();
        }

        public byte GenerateNumberOfConflicts()
        {
            byte number = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = i+1; j < 8; j++)
                {
                    if (_rows[i] == _rows[j] || Math.Abs(_rows[i]-_rows[j]) == Math.Abs(i-j))
                    {
                        number++;
                        //Console.WriteLine($"{i+1} : {j+1}");
                    }
                }
            }
            return number;
        }

        private byte[] GenerateRandom()
        {
            byte[] result = new byte[8];
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                result[i] = (byte)(random.Next() % 8);
            }

            return result;
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    result += _rows[i-1] == j-1 ? "()" : (i % 2 + j) % 2 == 1 ? "▓▓" : "░░";
                }
                result += '\n';
            }
            return result;
        }

        public List<ChessBoard> GeneratePossibleMoves()
        {
            List<ChessBoard> result = new List<ChessBoard>(56);
            for (byte i = 0; i < 8; i++)
            {
                for (byte j = 0; j < 8; j++)
                {
                    if (_rows[i] == j) continue;
                    byte[] current = new byte[8];
                    Array.Copy(_rows, current, 8);
                    current[i] = j;
                    result.Add(new ChessBoard(current));
                }
            }
            return result;
        }
    }
}