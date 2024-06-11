namespace AniList.Forms
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.page = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.user = new Guna.UI2.WinForms.Guna2Button();
            this.anime = new Guna.UI2.WinForms.Guna2Button();
            this.home = new Guna.UI2.WinForms.Guna2Button();
            this.button7 = new System.Windows.Forms.Button();
            this.forward = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.search = new Guna.UI2.WinForms.Guna2TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.label6.Location = new System.Drawing.Point(122, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 43);
            this.label6.TabIndex = 7;
            this.label6.Text = "anilist admin";
            // 
            // page
            // 
            this.page.AutoScroll = true;
            this.page.Location = new System.Drawing.Point(0, 65);
            this.page.Margin = new System.Windows.Forms.Padding(0);
            this.page.Name = "page";
            this.page.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.page.Size = new System.Drawing.Size(1161, 762);
            this.page.TabIndex = 8;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.Controls.Add(this.user);
            this.guna2Panel1.Controls.Add(this.anime);
            this.guna2Panel1.Controls.Add(this.home);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2Panel1.Location = new System.Drawing.Point(374, 20);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(253, 31);
            this.guna2Panel1.TabIndex = 0;
            // 
            // user
            // 
            this.user.Animated = true;
            this.user.AutoRoundedCorners = true;
            this.user.BorderRadius = 10;
            this.user.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.user.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.user.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.user.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.user.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.user.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.user.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.user.ForeColor = System.Drawing.Color.Silver;
            this.user.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.user.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.user.Location = new System.Drawing.Point(168, 4);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(80, 23);
            this.user.TabIndex = 2;
            this.user.Text = "User";
            this.toolTip1.SetToolTip(this.user, "Manage users");
            this.user.UseTransparentBackground = true;
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // anime
            // 
            this.anime.Animated = true;
            this.anime.AutoRoundedCorners = true;
            this.anime.BorderRadius = 10;
            this.anime.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.anime.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.anime.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.anime.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.anime.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.anime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.anime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.anime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.anime.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.anime.ForeColor = System.Drawing.Color.Silver;
            this.anime.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.anime.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.anime.Location = new System.Drawing.Point(86, 4);
            this.anime.Name = "anime";
            this.anime.Size = new System.Drawing.Size(80, 23);
            this.anime.TabIndex = 1;
            this.anime.Text = "Anime";
            this.toolTip1.SetToolTip(this.anime, "Manage Anime");
            this.anime.UseTransparentBackground = true;
            this.anime.Click += new System.EventHandler(this.anime_Click);
            // 
            // home
            // 
            this.home.Animated = true;
            this.home.AutoRoundedCorners = true;
            this.home.BorderRadius = 10;
            this.home.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.home.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.home.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.home.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.home.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.home.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.home.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.home.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.home.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.home.ForeColor = System.Drawing.Color.Silver;
            this.home.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.home.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.home.Location = new System.Drawing.Point(4, 4);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(80, 23);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
            this.home.UseTransparentBackground = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(296, 14);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(29, 39);
            this.button7.TabIndex = 11;
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.button7, "Logout");
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // forward
            // 
            this.forward.FlatAppearance.BorderSize = 0;
            this.forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forward.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forward.ForeColor = System.Drawing.Color.White;
            this.forward.Image = ((System.Drawing.Image)(resources.GetObject("forward.Image")));
            this.forward.Location = new System.Drawing.Point(62, 7);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(42, 61);
            this.forward.TabIndex = 10;
            this.forward.UseVisualStyleBackColor = true;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // back
            // 
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(14, 7);
            this.back.Margin = new System.Windows.Forms.Padding(18, 3, 3, 3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(42, 61);
            this.back.TabIndex = 9;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // search
            // 
            this.search.Animated = true;
            this.search.AutoRoundedCorners = true;
            this.search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(46)))));
            this.search.BorderRadius = 15;
            this.search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search.DefaultText = "";
            this.search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.search.IconLeft = ((System.Drawing.Image)(resources.GetObject("search.IconLeft")));
            this.search.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.search.IconLeftSize = new System.Drawing.Size(15, 15);
            this.search.Location = new System.Drawing.Point(690, 20);
            this.search.Name = "search";
            this.search.PasswordChar = '\0';
            this.search.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(126)))), ((int)(((byte)(129)))));
            this.search.PlaceholderText = " Search anime";
            this.search.SelectedText = "";
            this.search.Size = new System.Drawing.Size(256, 33);
            this.search.TabIndex = 13;
            this.search.TextOffset = new System.Drawing.Point(5, 0);
            this.search.Visible = false;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(993, 12);
            this.button8.Margin = new System.Windows.Forms.Padding(18, 3, 3, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(30, 30);
            this.button8.TabIndex = 16;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1024, 12);
            this.button3.Margin = new System.Windows.Forms.Padding(18, 3, 3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 15;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1066, 835);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.page);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Panel page;
        private System.Windows.Forms.Button button7;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public Guna.UI2.WinForms.Guna2Button user;
        public Guna.UI2.WinForms.Guna2Button anime;
        public Guna.UI2.WinForms.Guna2Button home;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip1;
        public Guna.UI2.WinForms.Guna2TextBox search;
    }
}