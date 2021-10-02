using System.Collections.Generic;

namespace AsdLab1
{
    
    public static class Bfs
    {
        public static int Iterations;
        public static int InMemory;
        public static IState Search(IState origin)
        {
            Iterations = 0;
            InMemory = 0;
            Queue<IState> bfsQueue = new Queue<IState>();
            IState currentNode = origin;
            while (currentNode.Priority != 0)
            {
                foreach (var child in currentNode.Children)
                {
                    bfsQueue.Enqueue(child);
                    InMemory++;
                }
                currentNode = bfsQueue.Dequeue();
                Iterations++;
            }
            return currentNode;
        }
    }
}