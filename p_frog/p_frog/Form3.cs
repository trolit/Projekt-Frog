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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        #region Przycisk powrotu do menu
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 back = new Form1();

            back.Show();
        }
        #endregion
        #region Odtworz dzwiek w momencie najechania na przycisk powrot (event - mouse hover)
        private void play_sound_powrot(object sender, EventArgs e)
        {
            SoundPlayer snd = new SoundPlayer(Properties.Resources.frog_effect_2);
            snd.Play();
        }
        #endregion
    }
}
