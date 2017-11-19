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

        #region 1. Przycisk_graj(przechodzi do okna gry)
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 graj = new Form2();
            graj.Show();

        }
        #endregion
        #region 2. Przycisk wyjście(kończy działanie aplikacji)
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region 3. Odtwórz_dźwiek(dla wyjścia)
        private void play_sound_wyjdz(object sender, EventArgs e)
        {
            SoundPlayer wyjdz = new SoundPlayer(Properties.Resources.frog_effect_2);
            wyjdz.Play();
        }
        #endregion
        #region 4. Odtwórz_dźwiek(dla graj)
        private void play_sound_graj(object sender, EventArgs e)
        {
            SoundPlayer graj = new SoundPlayer(Properties.Resources.frog_effect_1);
            graj.Play();
        }
        #endregion
        #region 5. Odtwórz_dźwiek(dla ustawień)
        private void play_sound_ustawienia(object sender, EventArgs e)
        {
            SoundPlayer ustawienia = new SoundPlayer(Properties.Resources.frog_effect_3);
            ustawienia.Play();
        }
        #endregion
        #region 6. Przycisk ustawienia(przechodzi do okna ustawień)
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 ustawienia = new Form3();
            ustawienia.Show();
        }

        #endregion
        #region 7. Instrukcja(pokaz na ekran, ukryj z ekranu i odtwórz dzwiek)
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
