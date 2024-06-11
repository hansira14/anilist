namespace AniList.UC
{
    partial class userprofile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userprofile));
            this.main = new System.Windows.Forms.Panel();
            this.here = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.favorites = new Guna.UI2.WinForms.Guna2Button();
            this.anilist = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.stats = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.Label();
            this.pic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.main.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.AutoScroll = true;
            this.main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.main.Controls.Add(this.here);
            this.main.Controls.Add(this.panel2);
            this.main.Controls.Add(this.panel1);
            this.main.Dock = System.Windows.Forms.DockStyle.Left;
            this.main.Location = new System.Drawing.Point(0, 0);
            this.main.Margin = new System.Windows.Forms.Padding(0);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(1110, 762);
            this.main.TabIndex = 20;
            // 
            // here
            // 
            this.here.AutoSize = true;
            this.here.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.here.Location = new System.Drawing.Point(0, 224);
            this.here.Margin = new System.Windows.Forms.Padding(0);
            this.here.MinimumSize = new System.Drawing.Size(1066, 45);
            this.here.Name = "here";
            this.here.Size = new System.Drawing.Size(1066, 45);
            this.here.TabIndex = 56;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel2.Controls.Add(this.favorites);
            this.panel2.Controls.Add(this.anilist);
            this.panel2.Controls.Add(this.guna2Button3);
            this.panel2.Controls.Add(this.stats);
            this.panel2.Location = new System.Drawing.Point(0, 179);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1066, 45);
            this.panel2.TabIndex = 1;
            // 
            // favorites
            // 
            this.favorites.BackColor = System.Drawing.Color.Transparent;
            this.favorites.BorderRadius = 6;
            this.favorites.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.favorites.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.favorites.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.favorites.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.favorites.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.favorites.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.favorites.DisabledState.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.favorites.FillColor = System.Drawing.Color.Transparent;
            this.favorites.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.favorites.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.favorites.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.favorites.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.favorites.Location = new System.Drawing.Point(705, 1);
            this.favorites.Margin = new System.Windows.Forms.Padding(38, 10, 0, 0);
            this.favorites.Name = "favorites";
            this.favorites.Size = new System.Drawing.Size(159, 41);
            this.favorites.TabIndex = 59;
            this.favorites.Text = "FAVORITES";
            this.favorites.UseTransparentBackground = true;
            this.favorites.Click += new System.EventHandler(this.favorites_Click);
            // 
            // anilist
            // 
            this.anilist.BackColor = System.Drawing.Color.Transparent;
            this.anilist.BorderRadius = 6;
            this.anilist.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.anilist.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.anilist.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.anilist.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.anilist.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.anilist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.anilist.DisabledState.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.anilist.FillColor = System.Drawing.Color.Transparent;
            this.anilist.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.anilist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.anilist.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.anilist.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.anilist.Location = new System.Drawing.Point(535, 1);
            this.anilist.Margin = new System.Windows.Forms.Padding(38, 10, 0, 0);
            this.anilist.Name = "anilist";
            this.anilist.Size = new System.Drawing.Size(159, 41);
            this.anilist.TabIndex = 58;
            this.anilist.Text = "ANIME LIST";
            this.anilist.UseTransparentBackground = true;
            this.anilist.Click += new System.EventHandler(this.anilist_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 6;
            this.guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button3.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.guna2Button3.Location = new System.Drawing.Point(195, 1);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(38, 10, 0, 0);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(159, 41);
            this.guna2Button3.TabIndex = 56;
            this.guna2Button3.Text = "OVERVIEW";
            this.guna2Button3.UseTransparentBackground = true;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // stats
            // 
            this.stats.BackColor = System.Drawing.Color.Transparent;
            this.stats.BorderRadius = 6;
            this.stats.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.stats.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.stats.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.stats.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.stats.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.stats.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.stats.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.stats.FillColor = System.Drawing.Color.Transparent;
            this.stats.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.stats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.stats.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.stats.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.stats.Location = new System.Drawing.Point(365, 1);
            this.stats.Margin = new System.Windows.Forms.Padding(38, 10, 0, 0);
            this.stats.Name = "stats";
            this.stats.Size = new System.Drawing.Size(159, 41);
            this.stats.TabIndex = 57;
            this.stats.Text = "STATISTICS";
            this.stats.UseTransparentBackground = true;
            this.stats.Click += new System.EventHandler(this.stats_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.pic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 179);
            this.panel1.TabIndex = 0;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.username.Location = new System.Drawing.Point(194, 130);
            this.username.Margin = new System.Windows.Forms.Padding(0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(87, 24);
            this.username.TabIndex = 8;
            this.username.Text = "Ira Hans";
            // 
            // pic
            // 
            this.pic.BorderRadius = 6;
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.ImageRotate = 0F;
            this.pic.Location = new System.Drawing.Point(55, 38);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(120, 120);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // userprofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.main);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "userprofile";
            this.Size = new System.Drawing.Size(1066, 762);
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox pic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label username;
        private Guna.UI2.WinForms.Guna2Button anilist;
        private Guna.UI2.WinForms.Guna2Button stats;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button favorites;
        private System.Windows.Forms.Panel here;
    }
}
