namespace CarGame1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.stripe1 = new System.Windows.Forms.PictureBox();
            this.stripe2 = new System.Windows.Forms.PictureBox();
            this.stripe3 = new System.Windows.Forms.PictureBox();
            this.stripe4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.car = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.Coinlbl = new System.Windows.Forms.Label();
            this.over = new System.Windows.Forms.Label();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.coin4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stripe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stripe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stripe3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stripe4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 463);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(329, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 463);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // stripe1
            // 
            this.stripe1.BackColor = System.Drawing.Color.White;
            this.stripe1.Location = new System.Drawing.Point(160, -32);
            this.stripe1.Name = "stripe1";
            this.stripe1.Size = new System.Drawing.Size(10, 100);
            this.stripe1.TabIndex = 0;
            this.stripe1.TabStop = false;
            // 
            // stripe2
            // 
            this.stripe2.BackColor = System.Drawing.Color.White;
            this.stripe2.Location = new System.Drawing.Point(160, 90);
            this.stripe2.Name = "stripe2";
            this.stripe2.Size = new System.Drawing.Size(10, 100);
            this.stripe2.TabIndex = 0;
            this.stripe2.TabStop = false;
            // 
            // stripe3
            // 
            this.stripe3.BackColor = System.Drawing.Color.White;
            this.stripe3.Location = new System.Drawing.Point(160, 222);
            this.stripe3.Name = "stripe3";
            this.stripe3.Size = new System.Drawing.Size(10, 100);
            this.stripe3.TabIndex = 0;
            this.stripe3.TabStop = false;
            // 
            // stripe4
            // 
            this.stripe4.BackColor = System.Drawing.Color.White;
            this.stripe4.Location = new System.Drawing.Point(160, 349);
            this.stripe4.Name = "stripe4";
            this.stripe4.Size = new System.Drawing.Size(10, 100);
            this.stripe4.TabIndex = 0;
            this.stripe4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // car
            // 
            this.car.Image = ((System.Drawing.Image)(resources.GetObject("car.Image")));
            this.car.Location = new System.Drawing.Point(101, 309);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(39, 74);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 1;
            this.car.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(42, 125);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(39, 74);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 1;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(176, 80);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(39, 74);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 1;
            this.enemy2.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Image = ((System.Drawing.Image)(resources.GetObject("enemy3.Image")));
            this.enemy3.Location = new System.Drawing.Point(269, 248);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(39, 74);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 1;
            this.enemy3.TabStop = false;
            // 
            // Coinlbl
            // 
            this.Coinlbl.AutoSize = true;
            this.Coinlbl.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coinlbl.ForeColor = System.Drawing.Color.Yellow;
            this.Coinlbl.Location = new System.Drawing.Point(12, 0);
            this.Coinlbl.Name = "Coinlbl";
            this.Coinlbl.Size = new System.Drawing.Size(69, 27);
            this.Coinlbl.TabIndex = 2;
            this.Coinlbl.Text = "Coins:";
            // 
            // over
            // 
            this.over.AutoSize = true;
            this.over.BackColor = System.Drawing.Color.Yellow;
            this.over.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.over.ForeColor = System.Drawing.Color.Red;
            this.over.Location = new System.Drawing.Point(115, 212);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(105, 27);
            this.over.TabIndex = 3;
            this.over.Text = "GameOver";
            // 
            // coin1
            // 
            this.coin1.BackColor = System.Drawing.Color.Transparent;
            this.coin1.Image = ((System.Drawing.Image)(resources.GetObject("coin1.Image")));
            this.coin1.Location = new System.Drawing.Point(88, 242);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(25, 25);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1.TabIndex = 4;
            this.coin1.TabStop = false;
            // 
            // coin2
            // 
            this.coin2.BackColor = System.Drawing.Color.Transparent;
            this.coin2.Image = ((System.Drawing.Image)(resources.GetObject("coin2.Image")));
            this.coin2.Location = new System.Drawing.Point(209, 347);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(25, 25);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2.TabIndex = 4;
            this.coin2.TabStop = false;
            // 
            // coin3
            // 
            this.coin3.BackColor = System.Drawing.Color.Transparent;
            this.coin3.Image = ((System.Drawing.Image)(resources.GetObject("coin3.Image")));
            this.coin3.Location = new System.Drawing.Point(269, 125);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(25, 25);
            this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin3.TabIndex = 4;
            this.coin3.TabStop = false;
            // 
            // coin4
            // 
            this.coin4.BackColor = System.Drawing.Color.Transparent;
            this.coin4.Image = ((System.Drawing.Image)(resources.GetObject("coin4.Image")));
            this.coin4.Location = new System.Drawing.Point(42, 30);
            this.coin4.Name = "coin4";
            this.coin4.Size = new System.Drawing.Size(25, 25);
            this.coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin4.TabIndex = 4;
            this.coin4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.coin4);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.over);
            this.Controls.Add(this.Coinlbl);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.car);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.stripe4);
            this.Controls.Add(this.stripe3);
            this.Controls.Add(this.stripe2);
            this.Controls.Add(this.stripe1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stripe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stripe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stripe3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stripe4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox stripe1;
        private System.Windows.Forms.PictureBox stripe2;
        private System.Windows.Forms.PictureBox stripe3;
        private System.Windows.Forms.PictureBox stripe4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.Label Coinlbl;
        private System.Windows.Forms.Label over;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.PictureBox coin4;
    }
}

