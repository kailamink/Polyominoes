using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyominoes
{
    class Squarie
    {
        public int Row { get; private set; }
        public int Col { get; private set; }

        public Squarie(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        /**
         * move (translate) the Squarie
         *
         * @param row : int - number of units to the right
         * @param col : int = number of units up
         */
        public void Translate(int row, int col)
        {
            this.Row += row;
            this.Col += col;
        }

        /**
         * rotate the Squarie 90 degrees counter-clockwise by applying the matrix
         * below to its implied upper left corner, which will be lower left 
         * after rotation: <br>
         * | 0 -1 |        <br>
         * | 1  0 |
         */
         
        // As we have redefined what it means to be a Squarie,
        // this is now going on our TODO list to revise. :|
        public void Rotate90()
        {
            int tmp = this.Row;
            this.Row = -1 - this.Col;
            this.Col = tmp;
        }

        /**
         * reflect the Squarie across the row-axis This transformation is not possible
         * in 2 dimensions
         */
        public void Reflect()
        {
            this.Col = -1 - this.Col;
        }

        public string ToString() => "[" + this.Row + "," + this.Col + "]";

        public bool Equals(Object other)
        {
            bool isEqual = false;
            if (other != null
                && (other.GetType() == typeof(Squarie))
                && ((Squarie)other).Row == this.Row
                && ((Squarie)other).Col == this.Col)
        {
                isEqual = true;
            }
            return isEqual;
        }
    }
}
