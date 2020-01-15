using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polyominoes
{
    public partial class PolyominoeForm : Form
    {
        Board board;

        public PolyominoeForm()
        {
            InitializeComponent();
            board = new Board((int)nudSize.Value);
            FillBoard(pnlBoard);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = board.Occupied[0, 0].ToString();
        }

        private void nudSize_ValueChanged(object sender, EventArgs e)
        {
            // TODO resize the board
        }

        private void FillBoard(Panel pnl)
        {
            int size = (int)nudSize.Value;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Panel mini = new Panel();

                    mini.Height = mini.Width = 50;
                    mini.Location = new Point(row * mini.Width, col * mini.Height);
                    SetSquarieColor(mini, row, col);
                  
                    mini.BorderStyle = BorderStyle.Fixed3D;
                    pnl.Controls.Add(mini);
                }
            }
        }

        public void SetSquarieColor(Panel mini, int row, int col)
        {
            if (board.Occupied[row, col] == Colors.YELLOW)
            {
                mini.BackColor = Color.Yellow;
            }
            else if (board.Occupied[row, col] == Colors.BLUE)
            {
                mini.BackColor = Color.Blue;
            }
            else if (board.Occupied[row, col] == Colors.GREEN)
            {
                mini.BackColor = Color.Green;
            }
            else if (board.Occupied[row, col] == Colors.RED)
            {
                mini.BackColor = Color.Red;
            }
            else
            {
                mini.BackColor = Color.Beige;
            }
        }
    }
}
