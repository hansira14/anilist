namespace AniList.Forms
{
    partial class forgotpass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forgotpass));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label4 = new System.Windows.Forms.Label();
            this.question1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.useremail = new Guna.UI2.WinForms.Guna2TextBox();
            this.answer1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.question2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.answer2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.pass1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.pass2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.proceed = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(332, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(154)))));
            this.label4.Location = new System.Drawing.Point(29, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Security Question 1";
            // 
            // question1
            // 
            this.question1.BackColor = System.Drawing.Color.Transparent;
            this.question1.BorderRadius = 4;
            this.question1.BorderThickness = 0;
            this.question1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.question1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.question1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.question1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.question1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.question1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.question1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.question1.ItemHeight = 30;
            this.question1.Items.AddRange(new object[] {
            "What was the name of your first pet?",
            "What was the model of your first car?",
            "In what city did you meet your spouse/significant other?",
            "What was the name of your favorite teacher in high school?",
            "What was the name of the street where you grew up?",
            "What was the title of the first book you remember reading?"});
            this.question1.Location = new System.Drawing.Point(30, 141);
            this.question1.Name = "question1";
            this.question1.Size = new System.Drawing.Size(322, 36);
            this.question1.TabIndex = 2;
            // 
            // useremail
            // 
            this.useremail.BorderRadius = 6;
            this.useremail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.useremail.DefaultText = "";
            this.useremail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.useremail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.useremail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.useremail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.useremail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.useremail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.useremail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.useremail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.useremail.Location = new System.Drawing.Point(30, 61);
            this.useremail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.useremail.Name = "useremail";
            this.useremail.PasswordChar = '\0';
            this.useremail.PlaceholderText = "Enter email or username";
            this.useremail.SelectedText = "";
            this.useremail.Size = new System.Drawing.Size(322, 36);
            this.useremail.TabIndex = 1;
            this.useremail.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // answer1
            // 
            this.answer1.BorderRadius = 6;
            this.answer1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.answer1.DefaultText = "";
            this.answer1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.answer1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.answer1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.answer1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.answer1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.answer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.answer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.answer1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.answer1.Location = new System.Drawing.Point(30, 183);
            this.answer1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.answer1.Name = "answer1";
            this.answer1.PasswordChar = '\0';
            this.answer1.PlaceholderText = "Enter Question 1 answer";
            this.answer1.SelectedText = "";
            this.answer1.Size = new System.Drawing.Size(322, 36);
            this.answer1.TabIndex = 3;
            this.answer1.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(154)))));
            this.label2.Location = new System.Drawing.Point(27, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 109;
            this.label2.Text = "Security Question 1";
            // 
            // question2
            // 
            this.question2.BackColor = System.Drawing.Color.Transparent;
            this.question2.BorderRadius = 4;
            this.question2.BorderThickness = 0;
            this.question2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.question2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.question2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.question2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.question2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.question2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.question2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.question2.ItemHeight = 30;
            this.question2.Items.AddRange(new object[] {
            "What was the name of your first pet?",
            "What was the model of your first car?",
            "In what city did you meet your spouse/significant other?",
            "What was the name of your favorite teacher in high school?",
            "What was the name of the street where you grew up?",
            "What was the title of the first book you remember reading?"});
            this.question2.Location = new System.Drawing.Point(30, 264);
            this.question2.Name = "question2";
            this.question2.Size = new System.Drawing.Size(322, 36);
            this.question2.TabIndex = 4;
            // 
            // answer2
            // 
            this.answer2.BorderRadius = 6;
            this.answer2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.answer2.DefaultText = "";
            this.answer2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.answer2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.answer2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.answer2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.answer2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.answer2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.answer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.answer2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.answer2.Location = new System.Drawing.Point(30, 308);
            this.answer2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.answer2.Name = "answer2";
            this.answer2.PasswordChar = '\0';
            this.answer2.PlaceholderText = "Enter Question 2 answer";
            this.answer2.SelectedText = "";
            this.answer2.Size = new System.Drawing.Size(322, 36);
            this.answer2.TabIndex = 5;
            this.answer2.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // pass1
            // 
            this.pass1.BorderRadius = 6;
            this.pass1.BorderThickness = 0;
            this.pass1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass1.DefaultText = "";
            this.pass1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pass1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pass1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pass1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pass1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.pass1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.pass1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pass1.ForeColor = System.Drawing.Color.White;
            this.pass1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.pass1.Location = new System.Drawing.Point(30, 388);
            this.pass1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pass1.Name = "pass1";
            this.pass1.PasswordChar = '*';
            this.pass1.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.pass1.PlaceholderText = "Enter new password";
            this.pass1.SelectedText = "";
            this.pass1.Size = new System.Drawing.Size(322, 36);
            this.pass1.TabIndex = 6;
            this.pass1.TextOffset = new System.Drawing.Point(8, 0);
            this.pass1.Visible = false;
            this.pass1.Leave += new System.EventHandler(this.pass1_Leave);
            // 
            // pass2
            // 
            this.pass2.BorderRadius = 6;
            this.pass2.BorderThickness = 0;
            this.pass2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass2.DefaultText = "";
            this.pass2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pass2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pass2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pass2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pass2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.pass2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.pass2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pass2.ForeColor = System.Drawing.Color.White;
            this.pass2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.pass2.Location = new System.Drawing.Point(30, 433);
            this.pass2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pass2.Name = "pass2";
            this.pass2.PasswordChar = '*';
            this.pass2.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.pass2.PlaceholderText = "Retype new password";
            this.pass2.SelectedText = "";
            this.pass2.Size = new System.Drawing.Size(322, 36);
            this.pass2.TabIndex = 7;
            this.pass2.TextOffset = new System.Drawing.Point(8, 0);
            this.pass2.Visible = false;
            this.pass2.Leave += new System.EventHandler(this.pass1_Leave);
            // 
            // proceed
            // 
            this.proceed.Animated = true;
            this.proceed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.proceed.BorderRadius = 6;
            this.proceed.BorderThickness = 2;
            this.proceed.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.proceed.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.proceed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.proceed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.proceed.FillColor = System.Drawing.Color.White;
            this.proceed.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.proceed.Location = new System.Drawing.Point(136, 499);
            this.proceed.Name = "proceed";
            this.proceed.Size = new System.Drawing.Size(103, 38);
            this.proceed.TabIndex = 118;
            this.proceed.Text = "Next";
            this.proceed.Click += new System.EventHandler(this.proceed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(27, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 119;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(46, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 17);
            this.label3.TabIndex = 120;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(36, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 121;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.guna2Button2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.guna2Button2.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.Location = new System.Drawing.Point(316, 391);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(30, 30);
            this.guna2Button2.TabIndex = 123;
            this.guna2Button2.Visible = false;
            this.guna2Button2.CheckedChanged += new System.EventHandler(this.guna2Button2_CheckedChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.guna2Button1.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.Location = new System.Drawing.Point(316, 437);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(30, 30);
            this.guna2Button1.TabIndex = 124;
            this.guna2Button1.Visible = false;
            this.guna2Button1.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            // 
            // forgotpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(389, 578);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proceed);
            this.Controls.Add(this.pass2);
            this.Controls.Add(this.pass1);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.question2);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.useremail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.question1);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "forgotpass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "forgotpass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label4;
        public Guna.UI2.WinForms.Guna2ComboBox question1;
        private Guna.UI2.WinForms.Guna2TextBox useremail;
        private Guna.UI2.WinForms.Guna2TextBox pass2;
        private Guna.UI2.WinForms.Guna2TextBox pass1;
        private Guna.UI2.WinForms.Guna2TextBox answer2;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2ComboBox question2;
        private Guna.UI2.WinForms.Guna2TextBox answer1;
        private Guna.UI2.WinForms.Guna2Button proceed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}