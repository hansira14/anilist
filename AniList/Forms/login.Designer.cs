namespace AniList
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.admin = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.proceed = new Guna.UI2.WinForms.Guna2Button();
            this.pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.username = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.status = new Guna.UI2.WinForms.Guna2TextBox();
            this.forgot = new System.Windows.Forms.Label();
            this.signup = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2PictureBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // admin
            // 
            this.admin.BackColor = System.Drawing.Color.Transparent;
            this.admin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.admin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.admin.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.admin.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.admin.Location = new System.Drawing.Point(438, 21);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(35, 20);
            this.admin.TabIndex = 15;
            this.admin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.admin.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.admin.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.admin.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.admin.CheckedChanged += new System.EventHandler(this.admin_CheckedChanged);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Controls.Add(this.admin);
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(800, 500);
            this.guna2PictureBox1.TabIndex = 15;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderThickness = 0;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.DefaultText = "Log-in";
            this.label1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.label1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.label1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.label1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.label1.FillColor = System.Drawing.SystemColors.Control;
            this.label1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.label1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(513, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label1.Name = "label1";
            this.label1.PasswordChar = '\0';
            this.label1.PlaceholderText = "";
            this.label1.ReadOnly = true;
            this.label1.SelectedText = "";
            this.label1.Size = new System.Drawing.Size(262, 31);
            this.label1.TabIndex = 16;
            this.label1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // proceed
            // 
            this.proceed.Animated = true;
            this.proceed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.proceed.BorderRadius = 10;
            this.proceed.BorderThickness = 1;
            this.proceed.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.proceed.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.proceed.DisabledState.FillColor = System.Drawing.SystemColors.Control;
            this.proceed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.proceed.Enabled = false;
            this.proceed.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.proceed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.proceed.ForeColor = System.Drawing.Color.White;
            this.proceed.Image = ((System.Drawing.Image)(resources.GetObject("proceed.Image")));
            this.proceed.Location = new System.Drawing.Point(623, 389);
            this.proceed.Name = "proceed";
            this.proceed.Size = new System.Drawing.Size(50, 50);
            this.proceed.TabIndex = 17;
            this.proceed.Click += new System.EventHandler(this.proceed_Click);
            // 
            // pass
            // 
            this.pass.BorderRadius = 6;
            this.pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass.DefaultText = "";
            this.pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pass.FillColor = System.Drawing.SystemColors.Control;
            this.pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.pass.Location = new System.Drawing.Point(530, 274);
            this.pass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(105)))), ((int)(((byte)(122)))));
            this.pass.PlaceholderText = "enter password";
            this.pass.SelectedText = "";
            this.pass.Size = new System.Drawing.Size(238, 36);
            this.pass.TabIndex = 2;
            this.pass.TextOffset = new System.Drawing.Point(8, 0);
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // username
            // 
            this.username.BorderRadius = 6;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.DefaultText = "";
            this.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.FillColor = System.Drawing.SystemColors.Control;
            this.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.username.Location = new System.Drawing.Point(530, 228);
            this.username.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(105)))), ((int)(((byte)(122)))));
            this.username.PlaceholderText = "enter username";
            this.username.SelectedText = "";
            this.username.Size = new System.Drawing.Size(238, 36);
            this.username.TabIndex = 1;
            this.username.TextOffset = new System.Drawing.Point(8, 0);
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(741, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 141;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.guna2ControlBox2.Location = new System.Drawing.Point(696, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 142;
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.guna2Button3.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.Location = new System.Drawing.Point(733, 278);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(30, 30);
            this.guna2Button3.TabIndex = 143;
            this.guna2Button3.CheckedChanged += new System.EventHandler(this.guna2Button3_CheckedChanged);
            // 
            // status
            // 
            this.status.BorderThickness = 0;
            this.status.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.status.DefaultText = "";
            this.status.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.status.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.status.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.status.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.status.FillColor = System.Drawing.SystemColors.Control;
            this.status.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.status.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.status.ForeColor = System.Drawing.Color.RosyBrown;
            this.status.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.status.Location = new System.Drawing.Point(530, 356);
            this.status.Name = "status";
            this.status.PasswordChar = '\0';
            this.status.PlaceholderText = "";
            this.status.ReadOnly = true;
            this.status.SelectedText = "";
            this.status.Size = new System.Drawing.Size(238, 22);
            this.status.TabIndex = 145;
            this.status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // forgot
            // 
            this.forgot.AutoSize = true;
            this.forgot.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.forgot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.forgot.Location = new System.Drawing.Point(673, 320);
            this.forgot.Name = "forgot";
            this.forgot.Size = new System.Drawing.Size(95, 15);
            this.forgot.TabIndex = 146;
            this.forgot.Text = "Forgot Password";
            this.forgot.Click += new System.EventHandler(this.forgot_Click);
            this.forgot.MouseEnter += new System.EventHandler(this.forgot_MouseEnter);
            this.forgot.MouseLeave += new System.EventHandler(this.forgot_MouseLeave);
            // 
            // signup
            // 
            this.signup.AutoSize = true;
            this.signup.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.signup.Location = new System.Drawing.Point(623, 458);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(50, 15);
            this.signup.TabIndex = 147;
            this.signup.Text = "Sign-up";
            this.signup.Click += new System.EventHandler(this.signup_Click);
            this.signup.MouseEnter += new System.EventHandler(this.forgot_MouseEnter);
            this.signup.MouseLeave += new System.EventHandler(this.forgot_MouseLeave);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.forgot);
            this.Controls.Add(this.status);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.proceed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2PictureBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ToggleSwitch admin;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox label1;
        private Guna.UI2.WinForms.Guna2Button proceed;
        private Guna.UI2.WinForms.Guna2TextBox pass;
        private Guna.UI2.WinForms.Guna2TextBox username;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2TextBox status;
        private System.Windows.Forms.Label forgot;
        private System.Windows.Forms.Label signup;
    }
}