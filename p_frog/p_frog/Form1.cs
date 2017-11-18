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

        #region Przycisk_graj(przechodzi do okna gry)
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 graj = new Form2();
            graj.Show();

        }
        #endregion
        #region Przycisk_wyjscie(konczy dzialanie aplikacji)
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region Odtworz_dzwiek(dla wyjscia)
        private void play_sound_wyjdz(object sender, EventArgs e)
        {
            SoundPlayer snd = new SoundPlayer(Properties.Resources.frog_effect_2);
            snd.Play();
        }
        #endregion
        #region Odwtorz_dzwiek(dla graj)
        private void play_sound_graj(object sender, EventArgs e)
        {
            SoundPlayer snd = new SoundPlayer(Properties.Resources.frog_effect_1);
            snd.Play();
        }
        #endregion
        #region Odtworz_dzwiek(dla ustawien)
        private void play_sound_ustawienia(object sender, EventArgs e)
        {
            SoundPlayer snd = new SoundPlayer(Properties.Resources.frog_effect_3);
            snd.Play();
        }
        #endregion
        #region Przycisk_ustawienia(przechodzi do okna ustawien)
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 ustawienia = new Form3();
            ustawienia.Show();
        }

        #endregion
        #region Instrukcja(pokaz na ekran, ukryj z ekranu i odtworz dzwiek)
        private void see_help_on(object sender, EventArgs e)
        {
            help.Visible = true;
            SoundPlayer snd = new SoundPlayer(Properties.Resources.frog_effect_4);
            snd.Play();
        }

        private void see_help_off(object sender, EventArgs e)
        {
            help.Visible = false;
        }
        #endregion
    }
}
