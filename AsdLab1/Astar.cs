using System;
using C5;

namespace AsdLab1
{
    public static class Astar
    {
        public static int Iterations;
        public static int StatesInMemory;
        public static int DeadEnds;
        public static IState Search(IState origin)
        {
            Iterations = 0;
            StatesInMemory = 0;
            DeadEnds = 0;
            IntervalHeap<IState> priorityQueue = new IntervalHeap<IState>(new AstarComparer());
            var solution = origin;
            IState previous = null;
            while (solution.Priority != 0)
            {
                foreach (var child in solution.Children)
                {
                    priorityQueue.Add(child);
                    StatesInMemory++;
                }
                previous = solution;
                solution = priorityQueue.FindMin();
                priorityQueue.DeleteMin();
                Iterations++;
                if (solution.Parent != previous)
                {
                    DeadEnds++;
                }

                //Console.WriteLine(((TreeNode)solution).State);
            }
            
            return solution;
        }
    }
}