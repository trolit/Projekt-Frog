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

        #region Przycisk powrotu do menu
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 przejscie = new Form1();
            this.Hide();
            przejscie.Show();
        }
        #endregion
        #region Przejscie na poziom 1
        private void level_1_Click(object sender, EventArgs e)
        {
            if(singlefrog.Checked && !doublefrog.Checked)
            {
                Form2 przejscie = new Form2();
                this.Hide();
                przejscie.Show();
            }
            else if(!singlefrog.Checked && doublefrog.Checked)
            {
                Form3 przejscie = new Form3();
                this.Hide();
                przejscie.Show();
            }
        }
        #endregion

        private void level_2_Click(object sender, EventArgs e)
        {
            if (singlefrog.Checked && !doublefrog.Checked)
            {
                Form5 przejscie = new Form5();
                this.Hide();
                przejscie.Show();
            }
        }

        #region 1. Zmiana kolorów kartonów
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
        #endregion
        #region 2. Przycisk do zatwierdzialania kodow
        private void confirm_Click(object sender, EventArgs e)
        {
            if(pass_checker.Text == "AF^@!")
            {
                padlock_lvl2.Visible = false;
                pass_checker.Font = new Font("Arial", 14);
                pass_checker.Text = "Kod poprawny!";              
            }
            else if(pass_checker.Text == "BGKKGS")
            {
                padlock_lvl3.Visible = false;
                pass_checker.Font = new Font("Arial", 14);
                pass_checker.Text = "Kod poprawny!";
            }
            else if (pass_checker.Text == "HGAA@$%")
            {
                padlock_lvl4.Visible = false;
                pass_checker.Font = new Font("Arial", 14);
                pass_checker.Text = "Kod poprawny!";
            }
            else if (pass_checker.Text == "%^@!AGQ")
            {
                padlock_lvl5.Visible = false;
                pass_checker.Font = new Font("Arial", 14);
                pass_checker.Text = "Kod poprawny!";
            }
            else if (pass_checker.Text == "AWPOKQ")
            {
                padlock_lvl6.Visible = false;
                pass_checker.Font = new Font("Arial", 14);
                pass_checker.Text = "Kod poprawny!";
            }
            else if (pass_checker.Text == "GPOLWK")
            {
                padlock_lvl7.Visible = false;
                pass_checker.Font = new Font("Arial", 14);
                pass_checker.Text = "Kod poprawny!";
            }
            else if (pass_checker.Text == "PADWOK")
            {
                padlock_lvl8.Visible = false;
                pass_checker.Font = new Font("Arial", 14);
                pass_checker.Text = "Kod poprawny!";
            }
            else if (pass_checker.Text == "HGJHQ@!")
            {
                padlock_lvl9.Visible = false;
                pass_checker.Font = new Font("Arial", 14);
                pass_checker.Text = "Kod poprawny!";
            }
            else
            {
                pass_checker.Font = new Font("Arial", 14);
                pass_checker.Text = "Kod błędny!";
            }
        }
        #endregion
    }
}
