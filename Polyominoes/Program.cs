using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polyominoes
{
    static class Program
    {
        // TODO --> Build out implementation of algorithm :)
        //test comment
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PolyominoeForm());
        }
    }
}
