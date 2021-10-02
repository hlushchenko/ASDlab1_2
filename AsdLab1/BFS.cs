using System.Collections.Generic;

namespace AsdLab1
{
    public static class Bfs
    {
        public static IState Search(IState origin)
        {
            Queue<IState> bfsQueue = new Queue<IState>();
            IState currentNode = origin;
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