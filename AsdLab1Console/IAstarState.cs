﻿#nullable enable
using System.Collections;
using System.Collections.Generic;

namespace AsdLab1Console
{
    public interface IAstarState
    {
        int Priority { get; }
        List<IAstarState> Children { get; }
    }
    
    public class AstarComparer : Comparer<IAstarState>
    {
        public override int Compare(IAstarState? x, IAstarState? y)
        {
            return x.Priority.CompareTo(y.Priority);
        }
    }
}