using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyominoes
{
    class Engine
    {
        private Board board;
        private List<Polyominoe> yellowKids;
        private List<Polyominoe> redKids;
        private List<Polyominoe> blueKids;
        private List<Polyominoe> greenKids;

        private List<List<Polyominoe>> allChildren;

        Stack<Polyominoe> optionStack = new Stack<Polyominoe>();

        List<Polyominoe> solution = new List<Polyominoe>();

        public Engine(Board board, 
            List<Polyominoe> yellowKids, 
            List<Polyominoe> redKids, 
            List<Polyominoe> blueKids, 
            List<Polyominoe> greenKids)
        {
            this.board = board;
            this.yellowKids = yellowKids;
            this.redKids = redKids;
            this.blueKids = blueKids;
            this.greenKids = greenKids;
        }

        public void Traverse(int colorIx)
        {
            // make sure colorIx is in bounds - if it's greater - we won!
            // fill up solution (and return it?)
           
            foreach (Polyominoe child in allChildren[colorIx]) //get the color we're up to
            {
                optionStack.Push(child); //push all the kids of this color onto our stack
            }

            Polyominoe current = optionStack.Pop();

            while (!board.isValid(current)) //somebody's gotta write this method
            {
                current = optionStack.Pop(); //no good try the next kid
            }
            // keep track of how many kids were popped. If number of popped kids is 
            // greater than the number of kids for that color, colorIx--

            Traverse(colorIx + 1); //this guy works, try next piece
        }
    }
}
