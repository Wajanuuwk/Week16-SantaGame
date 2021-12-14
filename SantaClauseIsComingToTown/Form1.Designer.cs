namespace SantaClauseIsComingToTown
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Sleigh = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.Tree = new System.Windows.Forms.PictureBox();
            this.SnowFlake = new System.Windows.Forms.PictureBox();
            this.house = new System.Windows.Forms.PictureBox();
            this.moon = new System.Windows.Forms.PictureBox();
            this.scorelabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Sleigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SnowFlake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.house)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).BeginInit();
            this.SuspendLayout();
            // 
            // Sleigh
            // 
            this.Sleigh.Image = ((System.Drawing.Image)(resources.GetObject("Sleigh.Image")));
            this.Sleigh.Location = new System.Drawing.Point(26, 144);
            this.Sleigh.Name = "Sleigh";
            this.Sleigh.Size = new System.Drawing.Size(137, 108);
            this.Sleigh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sleigh.TabIndex = 0;
            this.Sleigh.TabStop = false;
            this.Sleigh.Click += new System.EventHandler(this.timer1_Tick);
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-2, 378);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(803, 74);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // Tree
            // 
            this.Tree.Image = ((System.Drawing.Image)(resources.GetObject("Tree.Image")));
            this.Tree.Location = new System.Drawing.Point(431, 280);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(79, 112);
            this.Tree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tree.TabIndex = 2;
            this.Tree.TabStop = false;
            // 
            // SnowFlake
            // 
            this.SnowFlake.Image = ((System.Drawing.Image)(resources.GetObject("SnowFlake.Image")));
            this.SnowFlake.Location = new System.Drawing.Point(599, 1);
            this.SnowFlake.Name = "SnowFlake";
            this.SnowFlake.Size = new System.Drawing.Size(133, 78);
            this.SnowFlake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SnowFlake.TabIndex = 3;
            this.SnowFlake.TabStop = false;
            this.SnowFlake.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // house
            // 
            this.house.Image = ((System.Drawing.Image)(resources.GetObject("house.Image")));
            this.house.Location = new System.Drawing.Point(120, 298);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(126, 94);
            this.house.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.house.TabIndex = 4;
            this.house.TabStop = false;
            // 
            // moon
            // 
            this.moon.Image = ((System.Drawing.Image)(resources.GetObject("moon.Image")));
            this.moon.Location = new System.Drawing.Point(33, 12);
            this.moon.Name = "moon";
            this.moon.Size = new System.Drawing.Size(130, 67);
            this.moon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moon.TabIndex = 5;
            this.moon.TabStop = false;
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scorelabel.Location = new System.Drawing.Point(218, 39);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(126, 40);
            this.scorelabel.TabIndex = 6;
            this.scorelabel.Text = "Score: 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(339, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 78);
            this.button1.TabIndex = 7;
            this.button1.Text = " PLAY AGAIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(758, 445);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.moon);
            this.Controls.Add(this.house);
            this.Controls.Add(this.SnowFlake);
            this.Controls.Add(this.Tree);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.Sleigh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp_1);
            ((System.ComponentModel.ISupportInitialize)(this.Sleigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SnowFlake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.house)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Sleigh;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox Tree;
        private System.Windows.Forms.PictureBox SnowFlake;
        private System.Windows.Forms.PictureBox house;
        private System.Windows.Forms.PictureBox moon;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

