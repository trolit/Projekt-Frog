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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // przycisk powrotu
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 przejscie = new Form1();
            this.Hide();
            przejscie.Show();
        }

        private void level_1_Click(object sender, EventArgs e)
        {

        }

        private void switch_colors(object sender, EventArgs e)
        {
            if(doublefrog.Checked)
            {
                level_1.BackColor = Color.MediumPurple;
                level_2.BackColor = Color.MediumPurple;
                level_3.BackColor = Color.MediumPurple;
                level_4.BackColor = Color.MediumPurple;
                level_5.BackColor = Color.MediumPurple;
                level_6.BackColor = Color.MediumPurple;
                level_7.BackColor = Color.MediumPurple;
                level_8.BackColor = Color.MediumPurple;
                level_9.BackColor = Color.MediumPurple;
            }
            else if(!doublefrog.Checked)
            {
                level_1.BackColor = Color.Chartreuse;
                level_2.BackColor = Color.Chartreuse;
                level_3.BackColor = Color.Chartreuse;
                level_4.BackColor = Color.Chartreuse;
                level_5.BackColor = Color.Chartreuse;
                level_6.BackColor = Color.Chartreuse;
                level_7.BackColor = Color.Chartreuse;
                level_8.BackColor = Color.Chartreuse;
                level_9.BackColor = Color.Chartreuse;
            }
        }
    }
}
