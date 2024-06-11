namespace AniList.UC
{
    partial class user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user));
            this.pic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.usernamee = new System.Windows.Forms.Label();
            this.asd = new System.Windows.Forms.Label();
            this.join = new System.Windows.Forms.Label();
            this.animecount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.BorderRadius = 6;
            this.pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.ImageRotate = 0F;
            this.pic.Location = new System.Drawing.Point(12, 8);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(60, 64);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.label1_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.name.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.name.Location = new System.Drawing.Point(79, 8);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(131, 17);
            this.name.TabIndex = 1;
            this.name.Text = "Ira Hans Dedicatoria";
            this.name.Click += new System.EventHandler(this.label1_Click);
            // 
            // usernamee
            // 
            this.usernamee.AutoSize = true;
            this.usernamee.BackColor = System.Drawing.Color.Transparent;
            this.usernamee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usernamee.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(75)))), ((int)(((byte)(55)))));
            this.usernamee.Location = new System.Drawing.Point(79, 27);
            this.usernamee.Name = "usernamee";
            this.usernamee.Size = new System.Drawing.Size(56, 13);
            this.usernamee.TabIndex = 2;
            this.usernamee.Text = "@rukawa";
            this.usernamee.Click += new System.EventHandler(this.label1_Click);
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F, System.Drawing.FontStyle.Bold);
            this.asd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(75)))), ((int)(((byte)(55)))));
            this.asd.Location = new System.Drawing.Point(321, 52);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(87, 17);
            this.asd.TabIndex = 3;
            this.asd.Text = "anime added";
            // 
            // join
            // 
            this.join.AutoSize = true;
            this.join.BackColor = System.Drawing.Color.Transparent;
            this.join.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.join.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(75)))), ((int)(((byte)(55)))));
            this.join.Location = new System.Drawing.Point(104, 53);
            this.join.Name = "join";
            this.join.Size = new System.Drawing.Size(72, 13);
            this.join.TabIndex = 5;
            this.join.Text = "may 18, 2023";
            // 
            // animecount
            // 
            this.animecount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animecount.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.animecount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.animecount.Location = new System.Drawing.Point(321, 13);
            this.animecount.Name = "animecount";
            this.animecount.Size = new System.Drawing.Size(87, 39);
            this.animecount.TabIndex = 6;
            this.animecount.Text = "24";
            this.animecount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.animecount.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.animecount);
            this.Controls.Add(this.join);
            this.Controls.Add(this.asd);
            this.Controls.Add(this.usernamee);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pic);
            this.Name = "user";
            this.Size = new System.Drawing.Size(423, 82);
            this.MouseEnter += new System.EventHandler(this.user_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.user_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pic;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label usernamee;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.Label join;
        private System.Windows.Forms.Label animecount;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
