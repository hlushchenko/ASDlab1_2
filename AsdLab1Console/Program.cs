using System;
using System.Diagnostics;

namespace AsdLab1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] array = {3, 7, 0, 2, 5, 1, 6, 4};
            ChessBoard cb = new ChessBoard();
            Console.WriteLine(cb);
            Console.WriteLine();
            Stopwatch a = Stopwatch.StartNew();
            Console.WriteLine(((TreeNode)Astar.Search(new TreeNode(cb))).State);
            a.Stop();
            Console.WriteLine(a.Elapsed);
        }
    }
}