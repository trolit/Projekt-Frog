﻿using System;
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

    public partial class Form2 : Form
    {
        private int count_timer1 = 0;  
        private int count_timer2 = 0;
        bool right; 
        bool left;
        bool up;
        bool down;
        bool can_move = true;  // flaga sprawdzajaca czy frog moze chodzic, na start ustawiamy na true!
        
        public Form2()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(Form2_KeyDown);      // wywołanie punktu numer 3 - ruch żaby
            transparency_repair();                              // wywołanie punktu numer 6 - naprawa przezroczystości
        }

        // gdy frog wyjdzie za ekran cofa go do początku
        #region 1. Metoda sprawdzająca kolizję gdy frog wyjdzie za ekran
        private void Wykryj_kolizje_froga()
        {
            if (frog.Location.Y < -4 || frog.Location.Y > 450)
            {
                frog.Location = new Point(392, 428);
            }
            else if (frog.Location.X < -4 || frog.Location.X > 815)
            {
                frog.Location = new Point(392, 428);
            }
        }
        #endregion

        // metoda, że gdy frog się ruszy to odtworzy się frog_jump
        #region 2. Dźwiek skoku przy ruchu froga
        private void Wywolaj_dzwiek_skoku()
        {
            SoundPlayer skok = new SoundPlayer(Properties.Resources.frog_jump);
            skok.Play();
        }
        #endregion

        // tu jest opis ruchu froga i animacje odpalające się przy konkretnym ruchu
        #region 3. Rdzeń ruchu bohatera - froga
        void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            int x = frog.Location.X;
            int y = frog.Location.Y;
            timer3.Start();

            if (e.KeyCode == Keys.Right)
            {
                if (can_move == true)
                {
                    if (fatigue.Value >= 4)
                    {
                        timer1.Start();
                        right = true;
                        frog.Image = Image.FromFile("frog_right.gif");
                        x += 15;
                        Wywolaj_dzwiek_skoku();
                        fatigue.Value -= 4;
                    }
                    else
                    {
                        warning1.Visible = true;
                        warning2.Visible = true;
                        can_move = false;
                        timer2.Start();
                    }
                }
            }

            else if (e.KeyCode == Keys.Left)
            {
                if (can_move == true)
                {
                    timer1.Start();

                    if (fatigue.Value >= 4)
                    {
                        left = true;
                        frog.Image = Image.FromFile("frog_left.gif");
                        x -= 15;
                        Wywolaj_dzwiek_skoku();
                        fatigue.Value -= 4;
                    }
                    else
                    {
                        warning1.Visible = true;
                        warning2.Visible = true;
                        can_move = false;
                        timer2.Start();
                    }
                }

            }

            else if (e.KeyCode == Keys.Up)
            {
                if (can_move == true)
                {
                    timer1.Start();

                    // jesli zmeczenie jeszcze wieksze rowne 5 to moge isc do gory
                    if (fatigue.Value >= 5)
                    {
                        up = true;
                        frog.Image = Image.FromFile("frog_up.gif");
                        y -= 15;
                        Wywolaj_dzwiek_skoku();
                        fatigue.Value -= 5;
                    }
                    else
                    {
                        warning1.Visible = true;
                        warning2.Visible = true;
                        can_move = false;
                        timer2.Start();
                    }
                }

            }

            else if (e.KeyCode == Keys.Down)
            {
                if (can_move == true)
                {
                    timer1.Start();

                    if (fatigue.Value >= 5)
                    {
                        down = true;
                        frog.Image = Image.FromFile("frog_down.gif");
                        y += 15;
                        Wywolaj_dzwiek_skoku();
                        fatigue.Value -= 5;
                    }
                    else
                    {
                        warning1.Visible = true;
                        warning2.Visible = true;
                        can_move = false;
                        timer2.Start();
                    }
                }
            }

            // odzyskiwanie kondycji
            if (fatigue.Value <= 98)
            {
                fatigue.Value += 2;
            }

            frog.Location = new Point(x, y);
            Wykryj_kolizje_froga();
        }
#endregion

        // czasomierz sterujący przestaniem wykonania animacji ruchu
        #region 4. Timer1(odpowiedzialny za wywolanie odpowiednich obrazkow froga w danym momencie ruchu)
        private void timer1_Tick(object sender, EventArgs e)  
        {
            count_timer1++;
            // 1 sekunda = 1000 milisekund, timer ustawiamy w milisekundach
            if (count_timer1 == 1)
            {
                if (down == true)
                {
                    frog.Image = Image.FromFile("frog_down_stand.png");
                    count_timer1 = 0;
                    down = false;   // resetowanie kontrolek
                    up = false;
                    left = false;
                    right = false;
                }

                else if (up == true)
                {
                    frog.Image = Image.FromFile("frog_up_stand.png");
                    count_timer1 = 0;
                    down = false;
                    up = false;           
                    left = false;
                    right = false;
                }

                else if (left == true)
                {
                    frog.Image = Image.FromFile("frog_left_stand.png");
                    count_timer1 = 0;
                    down = false;
                    up = false;
                    left = false;
                    right = false;
                }

                else if (right == true)
                {
                    frog.Image = Image.FromFile("frog_right_stand.png");
                    count_timer1 = 0;
                    down = false;
                    up = false;
                    left = false;
                    right = false;
                }

                else
                {
                    count_timer1 = 0;   // rozwiazanie problemu ciaglego chodzenia froga
                }
            }
        }
        #endregion

        // czasomierz sterujący uzupełnieniem energii froga
        #region 5. Timer2(odpowiedzialny za odnowienie energii froga gdy spadnie do 0, pozbawienie go mozliwosci ruchu, ukrycie labelkow informujacych)
        private void timer2_Tick(object sender, EventArgs e)
        {
            count_timer2++;

            if (count_timer2 == 8)
            {
                fatigue.Value = 100;
                count_timer2 = 0;
                can_move = true;
                warning1.Visible = false;
                warning2.Visible = false;
                timer2.Stop();
            }

        }
        #endregion
       
        // bez tego picturebox na picturebox nie będzie przezroczysty!! 
        #region 6. Metoda naprawiająca problem przezroczystości pictureboxow
        private void transparency_repair()
        {
            frog.Parent = background_box;
            label1.Parent = background_box;
            police_car.Parent = background_box;
            car_column.Parent = background_box;
            truck_car.Parent = background_box;
            truck_car.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            car_column.BackColor = Color.Transparent;
            police_car.BackColor = Color.Transparent;
            frog.BackColor = Color.Transparent;
            frog.Location = new Point(392, 428);
        }

        #endregion

        // kontrola gdzie w obecnej chwili znajdują się pojazdy
        #region 7. Metody które zapętlają ruch pojazdów
        private void Check_police_car()
        {
            if (police_car.Location.X < -107)
            {
                police_car.Location = new Point(823, 220);
            }
        }
        
        private void Check_truck_car()
        {
            if (truck_car.Location.X > 897)
            {
                truck_car.Location = new Point(-269, 384);
            }
        }

        private void Check_car_column()
        {
            if (car_column.Location.X > 1000)
            {
                car_column.Location = new Point(-269, 297);
            }
        }
        #endregion

        // ruch pojazdami, żyją!!!
        #region 8. Timer3(odpowiedzialny za przesuwanie pictureboxow pojazdow)
        private void timer3_Tick(object sender, EventArgs e)
        {
            int p = police_car.Location.X; // lokalizacja radiowozu
            int c = car_column.Location.X; // lokalizacja kolumny samochodow
            int t = truck_car.Location.X;  // lokalizacja ciezarkowki

            p -= 10;
            police_car.Location = new Point(p, 222);
            Check_police_car();

            c += 9;
            car_column.Location = new Point(c, 297);
            Check_car_column();

            t += 6;
            truck_car.Location = new Point(t, 384);
            Check_truck_car();
        }

        private void background_box_Click(object sender, EventArgs e)
        {

        }
        #endregion

        // kolizja froga z pojazdami
    }

}
