using System;
using System.Diagnostics;

namespace AsdLab1
{
    class Program
    {
        private delegate IState _methodDelegate(IState a);

        static void Main(string[] args)
        {
            byte[] array = {3, 5, 1, 2, 5, 1, 7, 1};

            for (int j = 0; j < 2; j++)
            {
                ChessBoard cbTest = new ChessBoard();
                var testArray = ((TreeNode)Astar.Search(new TreeNode(cbTest))).State._rows;
                Random random = new Random();
                for (int i = 0; i < 2; i++)
                {
                    testArray[random.Next(8)] = (byte)random.Next(8);
                }
                testArray[random.Next(8)] = (byte)random.Next(8);


                _methodDelegate method = Bfs.Search;
                ChessBoard cb = new ChessBoard(testArray);
                var result = (TreeNode)method(new TreeNode(cb));
                Console.WriteLine($"{Bfs.Iterations} 0 {Bfs.Iterations} {Bfs.InMemory}");
            }
            
        }
    }
}