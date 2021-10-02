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
            int methodInt = 1;
            Int32.TryParse(Console.ReadLine(), out methodInt);
            _methodDelegate method = methodInt switch
            {
                1 => Astar.Search,
                2 => Bfs.Search,
                _ => Astar.Search
            };
            ChessBoard cb = new ChessBoard();
            Console.WriteLine("Start desk:\n" + cb +"\n");
            Stopwatch a = Stopwatch.StartNew();
            var result = (TreeNode)method(new TreeNode(cb));
            Console.WriteLine("Result desk:\n"+result.State);
            a.Stop();
            Console.WriteLine("Time:" + a.Elapsed);
        }
    }
}