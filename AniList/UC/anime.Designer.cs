namespace AniList
{
    partial class anime
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anime));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.add = new Guna.UI2.WinForms.Guna2CircleButton();
            this.watch = new Guna.UI2.WinForms.Guna2CircleButton();
            this.p2w = new Guna.UI2.WinForms.Guna2CircleButton();
            this.fin = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pictureBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 48);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(191)))), ((int)(((byte)(102)))));
            this.label3.Location = new System.Drawing.Point(184, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "9.03";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 6.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(21, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.add);
            this.panel2.Controls.Add(this.watch);
            this.panel2.Controls.Add(this.p2w);
            this.panel2.Controls.Add(this.fin);
            this.panel2.Location = new System.Drawing.Point(89, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 35);
            this.panel2.TabIndex = 9;
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // add
            // 
            this.add.Animated = true;
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.BorderColor = System.Drawing.Color.Empty;
            this.add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.add.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(96, 2);
            this.add.Name = "add";
            this.add.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.add.Size = new System.Drawing.Size(30, 30);
            this.add.TabIndex = 8;
            this.add.Text = "+";
            this.add.UseTransparentBackground = true;
            this.add.Visible = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            this.add.MouseHover += new System.EventHandler(this.add_MouseHover);
            // 
            // watch
            // 
            this.watch.Animated = true;
            this.watch.BorderColor = System.Drawing.Color.Empty;
            this.watch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.watch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.watch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.watch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.watch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.watch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.watch.ForeColor = System.Drawing.Color.White;
            this.watch.Image = ((System.Drawing.Image)(resources.GetObject("watch.Image")));
            this.watch.Location = new System.Drawing.Point(35, 4);
            this.watch.Name = "watch";
            this.watch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.watch.Size = new System.Drawing.Size(26, 26);
            this.watch.TabIndex = 5;
            this.watch.UseTransparentBackground = true;
            this.watch.Visible = false;
            this.watch.Click += new System.EventHandler(this.watch_Click);
            // 
            // p2w
            // 
            this.p2w.Animated = true;
            this.p2w.BorderColor = System.Drawing.Color.Empty;
            this.p2w.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.p2w.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.p2w.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.p2w.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.p2w.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.p2w.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.p2w.ForeColor = System.Drawing.Color.White;
            this.p2w.Image = ((System.Drawing.Image)(resources.GetObject("p2w.Image")));
            this.p2w.Location = new System.Drawing.Point(66, 4);
            this.p2w.Name = "p2w";
            this.p2w.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.p2w.Size = new System.Drawing.Size(26, 26);
            this.p2w.TabIndex = 7;
            this.p2w.UseTransparentBackground = true;
            this.p2w.Visible = false;
            this.p2w.Click += new System.EventHandler(this.p2w_Click);
            // 
            // fin
            // 
            this.fin.Animated = true;
            this.fin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fin.BorderColor = System.Drawing.Color.Empty;
            this.fin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.fin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.fin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.fin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fin.ForeColor = System.Drawing.Color.White;
            this.fin.Image = ((System.Drawing.Image)(resources.GetObject("fin.Image")));
            this.fin.Location = new System.Drawing.Point(4, 4);
            this.fin.Name = "fin";
            this.fin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.fin.Size = new System.Drawing.Size(26, 26);
            this.fin.TabIndex = 6;
            this.fin.UseTransparentBackground = true;
            this.fin.Visible = false;
            this.fin.Click += new System.EventHandler(this.fin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Controls.Add(this.panel1);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::AniList.Properties.Resources.default_01;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // anime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "anime";
            this.Size = new System.Drawing.Size(225, 160);
            this.Load += new System.EventHandler(this.anime_Load);
            this.Leave += new System.EventHandler(this.anime_Leave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pictureBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton watch;
        private Guna.UI2.WinForms.Guna2CircleButton fin;
        private Guna.UI2.WinForms.Guna2CircleButton p2w;
        private System.Windows.Forms.Panel panel2;
        public Guna.UI2.WinForms.Guna2CircleButton add;
    }
}
