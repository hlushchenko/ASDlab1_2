using System.Collections.Generic;

namespace AsdLab1
{
    public class TreeNode : IState
    {
        public int Priority => State.NumberOfConflicts;

        public List<IState> Children
        {
            get
            {
                List<IState> children = new List<IState>();
                foreach (var chessBoard in State.PossibleMoves)
                {
                    children.Add(new TreeNode(chessBoard));
                }

                foreach (var child in children)
                {
                    ((TreeNode)child).Parent = this;
                }

                return children;
            }
        }

        public IState Parent { get; private set; }

        public readonly ChessBoard State;

        public TreeNode(ChessBoard state)
        {
            State = state;
        }
    }
}