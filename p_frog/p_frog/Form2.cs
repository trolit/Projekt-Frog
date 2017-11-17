using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_frog
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(Form2_KeyDown);      // ruch zaby
        }

        void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            int x = frog.Location.X;
            int y = frog.Location.Y;

            if (e.KeyCode == Keys.Right) x += 5;
            else if (e.KeyCode == Keys.Left) x -= 5;
            else if (e.KeyCode == Keys.Up) y -= 5;
            else if (e.KeyCode == Keys.Down) y += 5;

            frog.Location = new Point(x, y);
        }

    }
}
