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

        // gdy wybierze opcję Graj
        #region 1. Przycisk_graj(przechodzi do okna gry)
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 graj = new Form2();
            graj.Show();

        }
        #endregion

        // gdy wybierze opcje Wyjdź
        #region 2. Przycisk wyjście(kończy działanie aplikacji)
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        // gdy najedzie myszką na przycisk wyjścia (mouse hover effect)
        #region 3. Odtwórz_dźwiek(dla wyjścia)
        private void play_sound_wyjdz(object sender, EventArgs e)
        {
            SoundPlayer wyjdz = new SoundPlayer(Properties.Resources.frog_effect_2);
            wyjdz.Play();
        }
        #endregion

        // gdy najedzie myszką na przycisk graj
        #region 4. Odtwórz_dźwiek(dla graj)
        private void play_sound_graj(object sender, EventArgs e)
        {
            SoundPlayer graj = new SoundPlayer(Properties.Resources.frog_effect_1);
            graj.Play();
        }
        #endregion

        // gdy najedzie na instrukcję, pokazują się informacje + dźwięk
        #region 5. Instrukcja(pokaz na ekran, ukryj z ekranu i odtwórz dzwiek)
        private void see_help_on(object sender, EventArgs e)
        {
            help.Visible = true;
            SoundPlayer pomoc = new SoundPlayer(Properties.Resources.frog_effect_4);
            pomoc.Play();
        }

        private void see_help_off(object sender, EventArgs e)
        {
            help.Visible = false;
        }
        #endregion
    }
}
