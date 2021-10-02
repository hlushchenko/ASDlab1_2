using System;
using C5;

namespace AsdLab1
{
    public static class Astar
    {
        public static IState Search(IState origin)
        {
            IntervalHeap<IState> priorityQueue = new IntervalHeap<IState>(new AstarComparer());
            var solution = origin;
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