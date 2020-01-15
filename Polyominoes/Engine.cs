using System.Collections.Generic;

namespace Polyominoes
{
    class Engine
    {
        private Board board;

        private List<List<Polyominoe>> allPermutations = new List<List<Polyominoe>>();

        private Stack<Polyominoe> optionStack = new Stack<Polyominoe>();
        private Polyominoe lastAdded;

        public Engine(Board board, 
            List<Polyominoe> yellowPerms, 
            List<Polyominoe> redPerms, 
            List<Polyominoe> bluePerms, 
            List<Polyominoe> greenPerms)
        {
            this.board = board;
            allPermutations.Add(yellowPerms);
            allPermutations.Add(redPerms);
            allPermutations.Add(bluePerms);
            allPermutations.Add(greenPerms);
        }

        public bool Solve()
        {
            return Solve(0);
        }

        private bool Solve(int colorIx)
        {
            if (colorIx == allPermutations.Count)
            {
                return true;
            }
            
            foreach (Polyominoe permutation in allPermutations[colorIx])
            {
                optionStack.Push(permutation);
            }

            Polyominoe current = optionStack.Pop();
            Colors currentColor = current.Color;
            int layersChanged = 0;

            while (!board.IsValid(current))
            {
                if (optionStack.Count == 0)
                {
                    return false;
                }
                current = optionStack.Pop(); 
                if (current.Color != currentColor)
                {
                    layersChanged++;
                    currentColor = current.Color;
                    board.Remove(lastAdded);
                }
            }

            board.Add(current);
            lastAdded = current;
            
            return Solve(colorIx - layersChanged + 1);
        }
    }
}
