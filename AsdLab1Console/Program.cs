using System;
using System.Diagnostics;

namespace AsdLab1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] array = {0, 0, 0, 0, 0, 0, 0, 0};
            ChessBoard cb = new ChessBoard(array);
            Console.WriteLine(cb);
            Console.WriteLine();
            Stopwatch a = Stopwatch.StartNew();
            Console.WriteLine(((TreeNode)Bfs.Search(new TreeNode(cb))).State);
            a.Stop();
            Console.WriteLine(a.Elapsed);
        }
    }
}