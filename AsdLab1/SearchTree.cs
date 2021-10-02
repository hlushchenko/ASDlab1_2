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