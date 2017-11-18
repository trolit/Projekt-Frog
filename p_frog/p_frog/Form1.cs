using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_frog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 graj = new Form2();
            graj.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void play_sound_wyjdz(object sender, EventArgs e)
        {
            SoundPlayer snd = new SoundPlayer(Properties.Resources.frog_effect_2);
            snd.Play();
        }

        private void play_sound_graj(object sender, EventArgs e)
        {
            SoundPlayer snd = new SoundPlayer(Properties.Resources.frog_effect_1);
            snd.Play();
        }
    }
}
