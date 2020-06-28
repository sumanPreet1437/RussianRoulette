using System.Windows.Forms;

namespace RussianRoulette
{
    partial class Form1
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
            this.ShootHead = new System.Windows.Forms.Button();
            this.Spin = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.ShootAway = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Point = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShootHead
            // 
            this.ShootHead.Location = new System.Drawing.Point(318, 195);
            this.ShootHead.Name = "ShootHead";
            this.ShootHead.Size = new System.Drawing.Size(96, 23);
            this.ShootHead.TabIndex = 0;
            this.ShootHead.Text = "Shoot At Head";
            this.ShootHead.UseVisualStyleBackColor = true;
            this.ShootHead.Click += new System.EventHandler(this.ShootHead_Click);
            // 
            // Spin
            // 
            this.Spin.Location = new System.Drawing.Point(102, 380);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(75, 23);
            this.Spin.TabIndex = 1;
            this.Spin.Text = "Spin";
            this.Spin.UseVisualStyleBackColor = true;
            this.Spin.Click += new System.EventHandler(this.Spin_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(3, 380);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 2;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // ShootAway
            // 
            this.ShootAway.Location = new System.Drawing.Point(318, 261);
            this.ShootAway.Name = "ShootAway";
            this.ShootAway.Size = new System.Drawing.Size(75, 23);
            this.ShootAway.TabIndex = 3;
            this.ShootAway.Text = "Shoot Away";
            this.ShootAway.UseVisualStyleBackColor = true;
            this.ShootAway.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Point
            // 
            this.Point.AutoSize = true;
            this.Point.Location = new System.Drawing.Point(12, 9);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(31, 13);
            this.Point.TabIndex = 5;
            this.Point.Text = "Point";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Russian Roulette";
            // 
            // PlayAgain
            // 
            this.PlayAgain.Location = new System.Drawing.Point(703, 4);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(96, 23);
            this.PlayAgain.TabIndex = 7;
            this.PlayAgain.Text = "Play Again";
            this.PlayAgain.UseVisualStyleBackColor = true;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RussianRoulette.Properties.Resources.z1;
            this.pictureBox1.Location = new System.Drawing.Point(699, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RussianRoulette.Properties.Resources.shoot;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ShootAway);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.ShootHead);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShootHead;
        private System.Windows.Forms.Button Spin;
        private new System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button ShootAway;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Point;
        private object form1;

        public object GetForm1()
        {
            return form1;
        }

        private void SetForm1(object value)
        {
            form1 = value;
        }

        public Form1(Button load)
        {
            Load = load;
        }

        private Label label1;
        private Button PlayAgain;
        private PictureBox pictureBox1;
    }
}

