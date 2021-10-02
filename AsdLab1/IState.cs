#nullable enable
using System.Collections;
using System.Collections.Generic;

namespace AsdLab1
{
    public interface IState
    {
        int Priority { get; }
        List<IState> Children { get; }
    }
    
    public class AstarComparer : Comparer<IState>
    {
        public override int Compare(IState? x, IState? y)
        {
            if (x != null && y != null) return x.Priority.CompareTo(y.Priority);
            return 0;
        }
    }
}