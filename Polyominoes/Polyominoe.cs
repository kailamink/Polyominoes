using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyominoes
{

    public enum Colors {NONE = 0, YELLOW, RED, BLUE, GREEN};

    class Polyominoe
    {
        public List<Squarie> Squaries { get; private set; }
        public Colors Color { get; private set; }

        public Polyominoe(int[,] squares, Colors color)
        {
            Color = color;
            Squaries = new List<Squarie>();
            for (int ordinal = 0; ordinal < squares.Length; ++ordinal)
            {
                Squaries.Add(new Squarie(squares[ordinal,0], squares[ordinal,1]));
            }
        }


        /**
         * move (translate) the Polyominoe
         *
         * @param x : int - number of units to the right
         * @param y : int = number of units up
         */
        public void Translate(int x, int y)
        {
            foreach(Squarie sqr in Squaries)
            {
                sqr.Translate(x, y);
            }
        }

        /**
         * rotate the Polyominoe 90 degrees counter-clockwise 
         */
        public void Rotate90()
        {
            foreach (Squarie sqr in Squaries)
            {
                sqr.Rotate90();
            }
            // need to move it move it

        }

        public override string ToString()
        {
            string strRV = "{ ";
            foreach (Squarie sqr in Squaries)
            {
                strRV += sqr.ToString();
            }
            strRV += "}";
            return strRV;
        }
    }
}
