namespace AniList.UC
{
    partial class adminactivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminactivity));
            this.name = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.pic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel = new Guna.UI2.WinForms.Guna2Panel();
            this.date = new System.Windows.Forms.Label();
            this.action = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.name.Location = new System.Drawing.Point(74, 23);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(145, 19);
            this.name.TabIndex = 7;
            this.name.Text = "Ira Hans Dedicatoria";
            // 
            // username
            // 
            this.username.Cursor = System.Windows.Forms.Cursors.Hand;
            this.username.Font = new System.Drawing.Font("Segoe UI Semibold", 8.75F, System.Drawing.FontStyle.Bold);
            this.username.ForeColor = System.Drawing.Color.Silver;
            this.username.Location = new System.Drawing.Point(7, 8);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(103, 17);
            this.username.TabIndex = 5;
            this.username.Text = "rukawa";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // pic
            // 
            this.pic.BorderRadius = 6;
            this.pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.ImageRotate = 0F;
            this.pic.Location = new System.Drawing.Point(14, 11);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(42, 42);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 4;
            this.pic.TabStop = false;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.BorderRadius = 10;
            this.panel.Controls.Add(this.username);
            this.panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel.Location = new System.Drawing.Point(237, 16);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(113, 31);
            this.panel.TabIndex = 8;
            // 
            // date
            // 
            this.date.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.date.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.Silver;
            this.date.Location = new System.Drawing.Point(377, 24);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(126, 17);
            this.date.TabIndex = 6;
            this.date.Text = "rukawa";
            // 
            // action
            // 
            this.action.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.action.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action.ForeColor = System.Drawing.Color.Silver;
            this.action.Location = new System.Drawing.Point(529, 24);
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(313, 17);
            this.action.TabIndex = 9;
            this.action.Text = "rukawa";
            // 
            // adminactivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.action);
            this.Controls.Add(this.date);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pic);
            this.Name = "adminactivity";
            this.Size = new System.Drawing.Size(867, 64);
            this.MouseEnter += new System.EventHandler(this.adminactivity_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.adminactivity_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label username;
        private Guna.UI2.WinForms.Guna2PictureBox pic;
        private Guna.UI2.WinForms.Guna2Panel panel;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label action;
    }
}
