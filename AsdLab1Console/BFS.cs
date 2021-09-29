using System.Collections.Generic;

namespace AsdLab1Console
{
    public static class Bfs
    {
        public static IAstarState Search(IAstarState origin)
        {
            Queue<IAstarState> bfsQueue = new Queue<IAstarState>();
            IAstarState currentNode = origin;
            while (currentNode.Priority != 0)
            {
                foreach (var child in currentNode.Children)
                {
                    bfsQueue.Enqueue(child);
                }
                currentNode = bfsQueue.Dequeue();
            }
            return currentNode;
        }
    }
}