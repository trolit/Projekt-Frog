﻿namespace p_frog
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.fatigue = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.warning1 = new System.Windows.Forms.Label();
            this.warning2 = new System.Windows.Forms.Label();
            this.frog = new System.Windows.Forms.PictureBox();
            this.screen = new System.Windows.Forms.Panel();
            this.win_no = new System.Windows.Forms.Button();
            this.win_yes = new System.Windows.Forms.Button();
            this.win_text_2 = new System.Windows.Forms.Label();
            this.win_text = new System.Windows.Forms.Label();
            this.win_box = new System.Windows.Forms.PictureBox();
            this.frog_hideout_3 = new System.Windows.Forms.PictureBox();
            this.frog_hideout_2 = new System.Windows.Forms.PictureBox();
            this.frog_hideout_1 = new System.Windows.Forms.PictureBox();
            this.tree_4 = new System.Windows.Forms.PictureBox();
            this.tree_3 = new System.Windows.Forms.PictureBox();
            this.tree_2 = new System.Windows.Forms.PictureBox();
            this.tree_1 = new System.Windows.Forms.PictureBox();
            this.frog_life_3 = new System.Windows.Forms.PictureBox();
            this.frog_life_2 = new System.Windows.Forms.PictureBox();
            this.frog_life_1 = new System.Windows.Forms.PictureBox();
            this.truck_car = new System.Windows.Forms.PictureBox();
            this.car_column = new System.Windows.Forms.PictureBox();
            this.police_car = new System.Windows.Forms.PictureBox();
            this.background_box = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lose_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.frog)).BeginInit();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.win_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frog_hideout_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frog_hideout_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frog_hideout_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frog_life_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frog_life_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frog_life_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck_car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_column)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.police_car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background_box)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // fatigue
            // 
            this.fatigue.BackColor = System.Drawing.Color.Crimson;
            this.fatigue.Location = new System.Drawing.Point(12, 24);
            this.fatigue.Name = "fatigue";
            this.fatigue.Size = new System.Drawing.Size(136, 23);
            this.fatigue.TabIndex = 1;
            this.fatigue.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Poziom energii:";
            // 
            // warning1
            // 
            this.warning1.AutoSize = true;
            this.warning1.BackColor = System.Drawing.Color.Yellow;
            this.warning1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.warning1.ForeColor = System.Drawing.Color.Black;
            this.warning1.Location = new System.Drawing.Point(367, 143);
            this.warning1.Name = "warning1";
            this.warning1.Size = new System.Drawing.Size(117, 12);
            this.warning1.TabIndex = 3;
            this.warning1.Text = "Zmęczyłeś się!";
            this.warning1.Visible = false;
            // 
            // warning2
            // 
            this.warning2.AutoSize = true;
            this.warning2.BackColor = System.Drawing.Color.Yellow;
            this.warning2.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.warning2.ForeColor = System.Drawing.Color.Black;
            this.warning2.Location = new System.Drawing.Point(383, 155);
            this.warning2.Name = "warning2";
            this.warning2.Size = new System.Drawing.Size(85, 11);
            this.warning2.TabIndex = 4;
            this.warning2.Text = "Odpocznij!";
            this.warning2.Visible = false;
            // 
            // frog
            // 
            this.frog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frog.BackColor = System.Drawing.Color.Transparent;
            this.frog.Image = global::p_frog.Properties.Resources.frog_up_stand;
            this.frog.Location = new System.Drawing.Point(423, 431);
            this.frog.Name = "frog";
            this.frog.Size = new System.Drawing.Size(30, 50);
            this.frog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.frog.TabIndex = 0;
            this.frog.TabStop = false;
            this.frog.WaitOnLoad = true;
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.Transparent;
            this.screen.Controls.Add(this.lose_text);
            this.screen.Controls.Add(this.win_no);
            this.screen.Controls.Add(this.win_yes);
            this.screen.Controls.Add(this.win_text_2);
            this.screen.Controls.Add(this.win_text);
            this.screen.Controls.Add(this.win_box);
            this.screen.Controls.Add(this.frog_hideout_3);
            this.screen.Controls.Add(this.frog_hideout_2);
            this.screen.Controls.Add(this.frog_hideout_1);
            this.screen.Controls.Add(this.tree_4);
            this.screen.Controls.Add(this.tree_3);
            this.screen.Controls.Add(this.tree_2);
            this.screen.Controls.Add(this.tree_1);
            this.screen.Controls.Add(this.frog_life_3);
            this.screen.Controls.Add(this.frog_life_2);
            this.screen.Controls.Add(this.frog_life_1);
            this.screen.Controls.Add(this.truck_car);
            this.screen.Controls.Add(this.car_column);
            this.screen.Controls.Add(this.police_car);
            this.screen.Controls.Add(this.frog);
            this.screen.Controls.Add(this.warning2);
            this.screen.Controls.Add(this.warning1);
            this.screen.Controls.Add(this.label1);
            this.screen.Controls.Add(this.fatigue);
            this.screen.Controls.Add(this.background_box);
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.ForeColor = System.Drawing.Color.DarkBlue;
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(842, 481);
            this.screen.TabIndex = 0;
            // 
            // win_no
            // 
            this.win_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.win_no.Location = new System.Drawing.Point(423, 264);
            this.win_no.Name = "win_no";
            this.win_no.Size = new System.Drawing.Size(85, 40);
            this.win_no.TabIndex = 23;
            this.win_no.Text = "NIE :( ";
            this.win_no.UseVisualStyleBackColor = true;
            this.win_no.Visible = false;
            this.win_no.Click += new System.EventHandler(this.win_no_Click);
            // 
            // win_yes
            // 
            this.win_yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.win_yes.Location = new System.Drawing.Point(325, 264);
            this.win_yes.Name = "win_yes";
            this.win_yes.Size = new System.Drawing.Size(85, 40);
            this.win_yes.TabIndex = 22;
            this.win_yes.Text = "TAK :)";
            this.win_yes.UseVisualStyleBackColor = true;
            this.win_yes.Visible = false;
            this.win_yes.Click += new System.EventHandler(this.win_yes_Click);
            // 
            // win_text_2
            // 
            this.win_text_2.AutoSize = true;
            this.win_text_2.Location = new System.Drawing.Point(322, 228);
            this.win_text_2.Name = "win_text_2";
            this.win_text_2.Size = new System.Drawing.Size(196, 13);
            this.win_text_2.TabIndex = 21;
            this.win_text_2.Text = "Czy chcesz wrócić do menu głównego?";
            this.win_text_2.Visible = false;
            // 
            // win_text
            // 
            this.win_text.AutoSize = true;
            this.win_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.win_text.Location = new System.Drawing.Point(358, 204);
            this.win_text.Name = "win_text";
            this.win_text.Size = new System.Drawing.Size(126, 24);
            this.win_text.TabIndex = 20;
            this.win_text.Text = "WYGRANA !";
            this.win_text.Visible = false;
            // 
            // win_box
            // 
            this.win_box.BackColor = System.Drawing.Color.Transparent;
            this.win_box.Location = new System.Drawing.Point(291, 192);
            this.win_box.Name = "win_box";
            this.win_box.Size = new System.Drawing.Size(252, 127);
            this.win_box.TabIndex = 19;
            this.win_box.TabStop = false;
            this.win_box.Visible = false;
            // 
            // frog_hideout_3
            // 
            this.frog_hideout_3.Image = ((System.Drawing.Image)(resources.GetObject("frog_hideout_3.Image")));
            this.frog_hideout_3.Location = new System.Drawing.Point(559, -12);
            this.frog_hideout_3.Name = "frog_hideout_3";
            this.frog_hideout_3.Size = new System.Drawing.Size(59, 50);
            this.frog_hideout_3.TabIndex = 18;
            this.frog_hideout_3.TabStop = false;
            // 
            // frog_hideout_2
            // 
            this.frog_hideout_2.Image = ((System.Drawing.Image)(resources.GetObject("frog_hideout_2.Image")));
            this.frog_hideout_2.Location = new System.Drawing.Point(385, -12);
            this.frog_hideout_2.Name = "frog_hideout_2";
            this.frog_hideout_2.Size = new System.Drawing.Size(59, 50);
            this.frog_hideout_2.TabIndex = 17;
            this.frog_hideout_2.TabStop = false;
            // 
            // frog_hideout_1
            // 
            this.frog_hideout_1.Image = ((System.Drawing.Image)(resources.GetObject("frog_hideout_1.Image")));
            this.frog_hideout_1.Location = new System.Drawing.Point(197, -12);
            this.frog_hideout_1.Name = "frog_hideout_1";
            this.frog_hideout_1.Size = new System.Drawing.Size(58, 50);
            this.frog_hideout_1.TabIndex = 16;
            this.frog_hideout_1.TabStop = false;
            // 
            // tree_4
            // 
            this.tree_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tree_4.Image = ((System.Drawing.Image)(resources.GetObject("tree_4.Image")));
            this.tree_4.Location = new System.Drawing.Point(823, 45);
            this.tree_4.Name = "tree_4";
            this.tree_4.Size = new System.Drawing.Size(125, 29);
            this.tree_4.TabIndex = 15;
            this.tree_4.TabStop = false;
            // 
            // tree_3
            // 
            this.tree_3.Image = ((System.Drawing.Image)(resources.GetObject("tree_3.Image")));
            this.tree_3.Location = new System.Drawing.Point(823, 64);
            this.tree_3.Name = "tree_3";
            this.tree_3.Size = new System.Drawing.Size(125, 34);
            this.tree_3.TabIndex = 14;
            this.tree_3.TabStop = false;
            // 
            // tree_2
            // 
            this.tree_2.Image = ((System.Drawing.Image)(resources.GetObject("tree_2.Image")));
            this.tree_2.Location = new System.Drawing.Point(823, 90);
            this.tree_2.Name = "tree_2";
            this.tree_2.Size = new System.Drawing.Size(205, 53);
            this.tree_2.TabIndex = 13;
            this.tree_2.TabStop = false;
            // 
            // tree_1
            // 
            this.tree_1.Image = ((System.Drawing.Image)(resources.GetObject("tree_1.Image")));
            this.tree_1.Location = new System.Drawing.Point(823, 133);
            this.tree_1.Name = "tree_1";
            this.tree_1.Size = new System.Drawing.Size(125, 42);
            this.tree_1.TabIndex = 12;
            this.tree_1.TabStop = false;
            // 
            // frog_life_3
            // 
            this.frog_life_3.Image = ((System.Drawing.Image)(resources.GetObject("frog_life_3.Image")));
            this.frog_life_3.Location = new System.Drawing.Point(689, 3);
            this.frog_life_3.Name = "frog_life_3";
            this.frog_life_3.Size = new System.Drawing.Size(46, 46);
            this.frog_life_3.TabIndex = 11;
            this.frog_life_3.TabStop = false;
            // 
            // frog_life_2
            // 
            this.frog_life_2.Image = ((System.Drawing.Image)(resources.GetObject("frog_life_2.Image")));
            this.frog_life_2.Location = new System.Drawing.Point(741, 3);
            this.frog_life_2.Name = "frog_life_2";
            this.frog_life_2.Size = new System.Drawing.Size(46, 46);
            this.frog_life_2.TabIndex = 10;
            this.frog_life_2.TabStop = false;
            // 
            // frog_life_1
            // 
            this.frog_life_1.Image = ((System.Drawing.Image)(resources.GetObject("frog_life_1.Image")));
            this.frog_life_1.Location = new System.Drawing.Point(793, 3);
            this.frog_life_1.Name = "frog_life_1";
            this.frog_life_1.Size = new System.Drawing.Size(46, 46);
            this.frog_life_1.TabIndex = 9;
            this.frog_life_1.TabStop = false;
            // 
            // truck_car
            // 
            this.truck_car.Image = ((System.Drawing.Image)(resources.GetObject("truck_car.Image")));
            this.truck_car.Location = new System.Drawing.Point(-281, 375);
            this.truck_car.Name = "truck_car";
            this.truck_car.Size = new System.Drawing.Size(286, 49);
            this.truck_car.TabIndex = 8;
            this.truck_car.TabStop = false;
            // 
            // car_column
            // 
            this.car_column.Image = ((System.Drawing.Image)(resources.GetObject("car_column.Image")));
            this.car_column.Location = new System.Drawing.Point(-259, 297);
            this.car_column.Name = "car_column";
            this.car_column.Size = new System.Drawing.Size(264, 53);
            this.car_column.TabIndex = 7;
            this.car_column.TabStop = false;
            // 
            // police_car
            // 
            this.police_car.Image = ((System.Drawing.Image)(resources.GetObject("police_car.Image")));
            this.police_car.Location = new System.Drawing.Point(823, 220);
            this.police_car.Name = "police_car";
            this.police_car.Size = new System.Drawing.Size(107, 52);
            this.police_car.TabIndex = 6;
            this.police_car.TabStop = false;
            // 
            // background_box
            // 
            this.background_box.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("background_box.BackgroundImage")));
            this.background_box.Location = new System.Drawing.Point(-3, 0);
            this.background_box.Name = "background_box";
            this.background_box.Size = new System.Drawing.Size(845, 481);
            this.background_box.TabIndex = 5;
            this.background_box.TabStop = false;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 50;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lose_text
            // 
            this.lose_text.AutoSize = true;
            this.lose_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lose_text.Location = new System.Drawing.Point(338, 204);
            this.lose_text.Name = "lose_text";
            this.lose_text.Size = new System.Drawing.Size(170, 24);
            this.lose_text.TabIndex = 24;
            this.lose_text.Text = "PRZEGRAŁEŚ :( ";
            this.lose_text.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 481);
            this.Controls.Add(this.screen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Projekt Frog";
            ((System.ComponentModel.ISupportInitialize)(this.frog)).EndInit();
            this.screen.ResumeLayout(false);
            this.screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.win_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frog_hideout_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frog_hideout_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frog_hideout_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frog_life_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frog_life_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frog_life_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truck_car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_column)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.police_car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel screen;
        public System.Windows.Forms.PictureBox police_car;
        protected System.Windows.Forms.PictureBox frog;
        protected System.Windows.Forms.Timer timer1;
        protected System.Windows.Forms.Timer timer2;
        protected System.Windows.Forms.Timer timer3;
        protected System.Windows.Forms.ProgressBar fatigue;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label warning1;
        protected System.Windows.Forms.Label warning2;
        protected System.Windows.Forms.PictureBox background_box;
        protected System.Windows.Forms.PictureBox car_column;
        protected System.Windows.Forms.PictureBox truck_car;
        protected System.Windows.Forms.PictureBox frog_life_1;
        protected System.Windows.Forms.PictureBox frog_life_3;
        protected System.Windows.Forms.PictureBox frog_life_2;
        protected System.Windows.Forms.PictureBox tree_1;
        protected System.Windows.Forms.PictureBox tree_2;
        protected System.Windows.Forms.PictureBox tree_4;
        protected System.Windows.Forms.PictureBox tree_3;
        private System.Windows.Forms.PictureBox frog_hideout_1;
        private System.Windows.Forms.PictureBox frog_hideout_3;
        private System.Windows.Forms.PictureBox frog_hideout_2;
        private System.Windows.Forms.PictureBox win_box;
        private System.Windows.Forms.Label win_text;
        private System.Windows.Forms.Button win_no;
        private System.Windows.Forms.Button win_yes;
        private System.Windows.Forms.Label win_text_2;
        private System.Windows.Forms.Label lose_text;
    }
}