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
    interface IFrog_Collisions
    {
        void Wykryj_kolizje_froga();
        void Check_if_frog_on_tree();
        void Vehicle_Collision();
        void Frog_plant_Collision();
        void Frog_water_Collision();
    }

    public partial class Form2 : Form, IFrog_Collisions
    {
        private int count_timer1 = 0;           // licznik dla timer1
        private int count_timer2 = 0;           // licznik dla timer2
        int life = 3;                           // liczba zyc froga
        bool right;                             // zmienne boolowskie do kontrolowania animacji         
        bool left;
        bool up;
        bool down;
        bool can_move = true;                   // flaga sprawdzajaca czy frog moze chodzic, na start ustawiamy na true!
        bool hide_out_1 = false;                // skrytka pierwsza, druga i trzecia boolowska
        bool hide_out_2 = false;
        bool hide_out_3 = false;
        bool is_on_tree = false;                // flaga sprawdzajaca czy frog jest na kłodzie

        bool can_move_right = true;             // do krzaków zmienne boolowskie
        bool can_move_left = true;
        
        public Form2()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(Form2_KeyDown);      // wywołanie ruchu zaby
            transparency_repair();                              // naprawa przezroczystości                     
        }

        // KOLIZJE FROGA Z OTOCZENIEM
        #region 1. Frog - Screen Collision
        public void Wykryj_kolizje_froga()
        {
            if (frog.Location.Y < -20 || frog.Location.Y > 450)
            {
                frog.Location = new Point(392, 428);
            }
            else if (frog.Location.X < -4 || frog.Location.X > 815)
            {
                frog.Location = new Point(392, 428);
            }
        }
        #endregion
        #region 2. Frog - Vehicle Collision
        public void Vehicle_Collision()
        {
            SoundPlayer car_hit = new SoundPlayer(Properties.Resources.frog_car_hit);
            if (frog.Bounds.IntersectsWith(police_car.Bounds)) // wykrywa przeciecie dwoch pictureboxow
            {
                car_hit.Play();
                Frog_Life();
                timer3.Stop();
            }
            else if (frog.Bounds.IntersectsWith(car_column.Bounds))
            {
                car_hit.Play();
                Frog_Life();
                timer3.Stop();
            }
            else if (frog.Bounds.IntersectsWith(truck_car.Bounds))
            {
                car_hit.Play();
                Frog_Life();
                timer3.Stop();
            }
        }
        #endregion
        #region 3. Frog - Plant Collision
        public void Frog_plant_Collision()
        {
            if (frog.Bounds.IntersectsWith(plant_block1.Bounds) && frog.Location.X < 291 || frog.Bounds.IntersectsWith(plant_block2.Bounds) && frog.Location.X < 471)
            {
                can_move_right = false;
            }
            else if (frog.Bounds.IntersectsWith(plant_block1.Bounds) && frog.Location.X > 291 || frog.Bounds.IntersectsWith(plant_block2.Bounds) && frog.Location.X > 471)
            {
                can_move_left = false;
            }
            else
            {
                can_move_right = true;
                can_move_left = true;
            }
        }
        #endregion
        #region 4. Frog - Water Collision
        public void Frog_water_Collision()
        {
            if (frog.Bounds.IntersectsWith(water_area.Bounds) && is_on_tree == false)
            {
                SoundPlayer splash = new SoundPlayer(Properties.Resources.frog_splash_water);
                splash.Play();
                Frog_Life();
                timer3.Stop();
            }
        }
        #endregion
        #region 5. Frog - Tree Collision
        public void Check_if_frog_on_tree()
        {
            int c = frog.Location.X;
            int d = frog.Location.Y;

            if (frog.Bounds.IntersectsWith(tree_1.Bounds) || frog.Bounds.IntersectsWith(tree_2.Bounds) || frog.Bounds.IntersectsWith(tree_3.Bounds) || frog.Bounds.IntersectsWith(tree_4.Bounds) || frog.Bounds.IntersectsWith(tree_6.Bounds) || frog.Bounds.IntersectsWith(tree_8.Bounds) || frog.Bounds.IntersectsWith(tree_9.Bounds) || frog.Bounds.IntersectsWith(tree_11.Bounds) || frog.Bounds.IntersectsWith(tree_12.Bounds) || frog.Bounds.IntersectsWith(tree_13.Bounds) || frog.Bounds.IntersectsWith(tree_14.Bounds))
            {
                is_on_tree = true;
                //  c -= 10;  gdy drzewa plywaly, ale animacje wolniejsze
                c -= 3;
                frog.Location = new Point(c, d);
                Wykryj_kolizje_froga();
            }
            else
            {
                is_on_tree = false;
            }
        }
        #endregion

        // ZAKONCZENIA GIER 
        #region 1. Gdy przegrana
        private void End_Game()
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            can_move = false;

            SoundPlayer frog_lose = new SoundPlayer(Properties.Resources.lose_sound_fxd);
            frog_lose.Play();

            frog_coffin.Visible = true;
            frog_dead.Visible = true;
            lose_text.Visible = true;
            win_text_2.Visible = true;
            win_yes.Visible = true;
            win_no.Visible = true;
            win_box.Visible = true;
            bckg_lose.Visible = true;
        }
        #endregion
        #region 2. Gdy wygrana
        private void Wins_Game()
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            can_move = false;

            SoundPlayer win_sound = new SoundPlayer(Properties.Resources.win_sound);
            win_sound.Play();
            win_text.Visible = true;
            win_text_2.Visible = true;
            win_yes.Visible = true;
            win_no.Visible = true;
            win_box.Visible = true;
        }
        #endregion

        // CZASOMIERZE
        #region 1. Timer1(odpowiedzialny za wywolanie odpowiednich obrazkow froga w danym momencie ruchu)
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
        #region 2. Timer2(odpowiedzialny za odnowienie energii froga gdy spadnie do 0, pozbawienie go mozliwosci ruchu, ukrycie labelkow informujacych)
        private void timer2_Tick(object sender, EventArgs e)
        {
            count_timer2++;

            if (count_timer2 == 9)
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
        #region 3. Timer3(odpowiedzialny za ruch samochodow)
        private void timer3_Tick(object sender, EventArgs e)
        {
            int p = police_car.Location.X; // lokalizacja radiowozu
            int c = car_column.Location.X; // lokalizacja kolumny samochodow
            int t = truck_car.Location.X;  // lokalizacja ciezarkowki

            p -= 10;
            police_car.Location = new Point(p, 222);
            Check_police_car();

            c += 12;
            car_column.Location = new Point(c, 297);
            Check_car_column();

            t += 9;
            truck_car.Location = new Point(t, 375);
            Check_truck_car();

            Check_if_frog_on_tree();
            Frog_plant_Collision();
            Check_tree_move();
            Vehicle_Collision();
            Confirm_hideout();
            Frog_water_Collision();
            Vehicle_Collision();
        }
        #endregion
        #region 4. Timer4(odpowiedzialny za ruch drzew)
        private void timer4_Tick(object sender, EventArgs e)
        {
            // zakomentuj ciało żeby zobaczyć jak płynnie poruszają się samochody
            int tre1 = tree_1.Location.X;  // lokalizacja kłód, najnizsza
            int tre2 = tree_2.Location.X;
            int tre3 = tree_3.Location.X;
            int tre4 = tree_4.Location.X;
            int tre6 = tree_6.Location.X;
            int tre8 = tree_8.Location.X;
            int tre9 = tree_9.Location.X;
            int tre11 = tree_11.Location.X;
            int tre12 = tree_12.Location.X;
            int tre13 = tree_13.Location.X;
            int tre14 = tree_14.Location.X;

            tre1 -= 3;
            tre2 -= 3;
            tre3 -= 3;
            tre4 -= 3;
            tre6 -= 3;
            tre8 -= 3;
            tre9 -= 3;
            tre11 -= 3;
            tre12 -= 3;
            tre13 -= 3;
            tre14 -= 3;
            tree_1.Location = new Point(tre1, 135);
            tree_2.Location = new Point(tre2, 89);
            tree_3.Location = new Point(tre3, 67);
            tree_4.Location = new Point(tre4, 45);
            tree_6.Location = new Point(tre6, 115);
            tree_8.Location = new Point(tre8, 82);
            tree_9.Location = new Point(tre9, 82);
            tree_11.Location = new Point(tre11, 143);
            tree_12.Location = new Point(tre12, 143);
            tree_13.Location = new Point(tre13, 82);
            tree_14.Location = new Point(tre14, 55);
        }
        #endregion

        // KONTROLOWANIE LOKALIZACJI PICTUREBOXOW
        #region 1. Sprawdź lokalizacje pojazdów
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
        #region 2. Sprawdź lokalizacje drzew
        private void Check_tree_move()
        {
            if (tree_1.Location.X < -120)
            {
                tree_1.Location = new Point(823, 133);
            }
            else if (tree_2.Location.X < -200)
            {
                tree_2.Location = new Point(823, 90);
            }
            else if (tree_3.Location.X < -108)
            {
                tree_3.Location = new Point(823, 64);
            }
            else if (tree_4.Location.X < -119)
            {
                tree_4.Location = new Point(823, 55);
            }
            else if (tree_6.Location.X < -119)
            {
                tree_6.Location = new Point(823, 115);
            }
            else if (tree_8.Location.X < -119)
            {
                tree_8.Location = new Point(823, 82);
            }
            else if (tree_9.Location.X < -119)
            {
                tree_9.Location = new Point(823, 82);
            }
            else if (tree_11.Location.X < -119)
            {
                tree_11.Location = new Point(823, 143);
            }
            else if (tree_12.Location.X < -119)
            {
                tree_12.Location = new Point(823, 143);
            }
            else if (tree_13.Location.X < -119)
            {
                tree_13.Location = new Point(823, 82);
            }
            else if (tree_14.Location.X < -119)
            {
                tree_14.Location = new Point(823, 55);
            }
        }
        #endregion

        // KONTROLOWANIE ZADANIA, LICZBY ZYC, RUCHU FROGA
        #region 1. Frog - Stan żyć
        private void Frog_Life()
        {
            if (life == 3)
            {
                frog.Location = new Point(392, 428);
                frog_life_3.Visible = false;
                life = 2;
            }
            else if (life == 2)
            {
                frog.Location = new Point(392, 428);
                frog_life_2.Visible = false;
                life = 1;
            }
            else if (life == 1)
            {
                frog.Location = new Point(392, 428);
                frog_life_1.Visible = false;
                life = 0;
            }
            else if (life == 0)
            {
                End_Game();
            }
        }
        #endregion
        #region 2. Frog - Poruszanie
        void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            int x = frog.Location.X;
            int y = frog.Location.Y;
            timer3.Start();

            if (e.KeyCode == Keys.Right)
            {
                if (can_move == true && can_move_right == true)
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
                if (can_move == true && can_move_left == true)
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
        #region 3. Frog - stan zadania
        private void Confirm_hideout()
        {
            SoundPlayer frog_capture_point = new SoundPlayer(Properties.Resources.frog_saved_sound);

            if (frog.Bounds.IntersectsWith(frog_hideout_1.Bounds))
            {
                frog_hideout_1.Visible = false;
                hide_out_1 = true;
                frog_capture_point.Play();
                frog.Location = new Point(392, 428);
            }
            else if (frog.Bounds.IntersectsWith(frog_hideout_2.Bounds))
            {
                frog_hideout_2.Visible = false;
                hide_out_2 = true;
                frog_capture_point.Play();
                frog.Location = new Point(392, 428);
            }
            else if (frog.Bounds.IntersectsWith(frog_hideout_3.Bounds))
            {
                frog_hideout_3.Visible = false;
                hide_out_3 = true;
                frog_capture_point.Play();
                frog.Location = new Point(392, 428);
            }

            if (hide_out_1 == true && hide_out_2 == true && hide_out_3 == true)
            {
                Wins_Game();
            }
        }
        #endregion

        // POZOSTAŁE
        #region 1. Dźwiek skoku przy ruchu froga
        private void Wywolaj_dzwiek_skoku()
        {
            SoundPlayer skok = new SoundPlayer(Properties.Resources.frog_jump);
            skok.Play();
        }
        #endregion
        #region 2. Metoda naprawiająca problem faktycznej przezroczystości pictureboxow
        private void transparency_repair()
        {
            frog.Parent = background_box;
            label1.Parent = background_box;
            police_car.Parent = background_box;
            car_column.Parent = background_box;
            truck_car.Parent = background_box;
            frog_life_1.Parent = background_box;
            frog_life_2.Parent = background_box;
            frog_life_3.Parent = background_box;
            frog_life_1.BackColor = Color.Transparent;
            frog_life_2.BackColor = Color.Transparent;
            frog_life_3.BackColor = Color.Transparent;
            tree_1.Parent = background_box;
            tree_2.Parent = background_box;
            tree_3.Parent = background_box;
            tree_4.Parent = background_box;
            tree_6.Parent = background_box;
            tree_8.Parent = background_box;
            tree_9.Parent = background_box;
            tree_11.Parent = background_box;
            tree_12.Parent = background_box;
            tree_13.Parent = background_box;
            tree_14.Parent = background_box;
            frog_hideout_1.Parent = background_box;
            frog_hideout_1.BackColor = Color.Transparent;
            frog_hideout_2.Parent = background_box;
            frog_hideout_2.BackColor = Color.Transparent;
            frog_hideout_3.Parent = background_box;
            frog_hideout_3.BackColor = Color.Transparent;
            tree_1.BackColor = Color.Transparent;
            tree_2.BackColor = Color.Transparent;
            tree_3.BackColor = Color.Transparent;
            tree_4.BackColor = Color.Transparent;
            tree_6.BackColor = Color.Transparent;
            tree_8.BackColor = Color.Transparent;
            tree_9.BackColor = Color.Transparent;
            tree_11.BackColor = Color.Transparent;
            tree_12.BackColor = Color.Transparent;
            tree_13.BackColor = Color.Transparent;
            tree_14.BackColor = Color.Transparent;
            plant_block1.Parent = background_box;
            plant_block1.BackColor = Color.Transparent;
            plant_block2.Parent = background_box;
            plant_block2.BackColor = Color.Transparent;
            truck_car.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            car_column.BackColor = Color.Transparent;
            police_car.BackColor = Color.Transparent;
            frog.BackColor = Color.Transparent;
            frog.Location = new Point(392, 428); // tu zaba zaczyna
        }

        #endregion
        #region 3. Przycisk powrotu do menu
        private void win_yes_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 main_menu = new Form1();
            main_menu.Show();
        }
        #endregion
        #region 4. Przycisk wyjscia z gry
        private void win_no_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
#endregion
    }
}
