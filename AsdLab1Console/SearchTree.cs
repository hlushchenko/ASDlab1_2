using System.Collections.Generic;

namespace AsdLab1Console
{
    public class TreeNode : IAstarState
    {
        public int Priority => State.NumberOfConflicts;

        public List<IAstarState> Children
        {
            get
            {
                List<IAstarState> children = new List<IAstarState>();
                foreach (var chessBoard in State.PossibleMoves)
                {
                    children.Add(new TreeNode(chessBoard));
                }

                return children;
            }
        }

        public readonly ChessBoard State;

        public TreeNode(ChessBoard state)
        {
            State = state;
        }
    }
}