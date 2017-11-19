namespace p_frog
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
            this.screen = new System.Windows.Forms.Panel();
            this.warning2 = new System.Windows.Forms.Label();
            this.warning1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fatigue = new System.Windows.Forms.ProgressBar();
            this.frog = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frog)).BeginInit();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.Controls.Add(this.warning2);
            this.screen.Controls.Add(this.warning1);
            this.screen.Controls.Add(this.label1);
            this.screen.Controls.Add(this.fatigue);
            this.screen.Controls.Add(this.frog);
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(842, 481);
            this.screen.TabIndex = 0;
            // 
            // warning2
            // 
            this.warning2.AutoSize = true;
            this.warning2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.warning2.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.warning2.Location = new System.Drawing.Point(390, 155);
            this.warning2.Name = "warning2";
            this.warning2.Size = new System.Drawing.Size(75, 11);
            this.warning2.TabIndex = 4;
            this.warning2.Text = "Odpocznij!";
            this.warning2.Visible = false;
            // 
            // warning1
            // 
            this.warning1.AutoSize = true;
            this.warning1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.warning1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.warning1.Location = new System.Drawing.Point(376, 143);
            this.warning1.Name = "warning1";
            this.warning1.Size = new System.Drawing.Size(103, 12);
            this.warning1.TabIndex = 3;
            this.warning1.Text = "Zmęczyłeś się!";
            this.warning1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Poziom energii:";
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
            // frog
            // 
            this.frog.BackColor = System.Drawing.Color.Transparent;
            this.frog.Image = global::p_frog.Properties.Resources.frog_up_stand;
            this.frog.Location = new System.Drawing.Point(413, 431);
            this.frog.Name = "frog";
            this.frog.Size = new System.Drawing.Size(30, 50);
            this.frog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.frog.TabIndex = 0;
            this.frog.TabStop = false;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 481);
            this.Controls.Add(this.screen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Projekt Frog";
            this.screen.ResumeLayout(false);
            this.screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox frog;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar fatigue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label warning2;
        private System.Windows.Forms.Label warning1;
        private System.Windows.Forms.Timer timer2;
    }
}