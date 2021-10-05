using System;
using System.Diagnostics;

namespace AsdLab1
{
    class Program
    {
        private delegate IState _methodDelegate(IState a);
        static void Main(string[] args)
        {
            //byte[] array = {0, 0, 0, 0, 0, 0, 0, 0};
            Console.WriteLine("Select solving method (1 - A*, 2 - BFS)");
            Int32.TryParse(Console.ReadLine(), out var methodInt);
            _methodDelegate search = methodInt switch
            {
                1 => Astar.Search,
                2 => Bfs.Search,
                _ => Astar.Search
            };
            var board = new ChessBoard();
            Console.WriteLine("Start chessboard:\n" + board +"\n");
            var stopwatch = Stopwatch.StartNew();
            var result = search(new TreeNode(board));
            Console.WriteLine("Result chessboard:\n"+result);
            stopwatch.Stop();
            Console.WriteLine("Time:" + stopwatch.Elapsed);
        }
    }
}