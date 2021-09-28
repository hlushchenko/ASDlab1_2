using System;
using C5;

namespace AsdLab1Console
{
    public static class Astar
    {
        public static IAstarState Search(IAstarState node)
        {
            IntervalHeap<IAstarState> priorityQueue = new IntervalHeap<IAstarState>(new AstarComparer());
            var solution = node;
            while (solution.Priority != 0)
            {
                foreach (var child in solution.Children)
                {
                    priorityQueue.Add(child);
                }
                solution = priorityQueue.FindMin();
                priorityQueue.DeleteMin();
            }
            return solution;
        }
    }
}