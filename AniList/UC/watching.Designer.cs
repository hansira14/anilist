namespace AniList
{
    partial class watching
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(watching));
            this.title = new System.Windows.Forms.Label();
            this.eps = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progress = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.title.Location = new System.Drawing.Point(102, 26);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(97, 15);
            this.title.TabIndex = 1;
            this.title.Text = "Add some anime";
            this.title.TextChanged += new System.EventHandler(this.title_TextChanged_1);
            this.title.MouseEnter += new System.EventHandler(this.sMouseEnter);
            // 
            // eps
            // 
            this.eps.AutoSize = true;
            this.eps.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.eps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.eps.Location = new System.Drawing.Point(102, 44);
            this.eps.Name = "eps";
            this.eps.Size = new System.Drawing.Size(16, 13);
            this.eps.TabIndex = 2;
            this.eps.Text = "...";
            this.eps.MouseEnter += new System.EventHandler(this.sMouseEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.progress);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.eps);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 138);
            this.panel1.TabIndex = 0;
            this.panel1.MouseEnter += new System.EventHandler(this.sMouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.sMouseLeave);
            // 
            // progress
            // 
            this.progress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.progress.Location = new System.Drawing.Point(102, 70);
            this.progress.Name = "progress";
            this.progress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.progress.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(62)))), ((int)(((byte)(69)))));
            this.progress.Size = new System.Drawing.Size(100, 7);
            this.progress.TabIndex = 4;
            this.progress.Text = "guna2ProgressBar1";
            this.progress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.progress.Value = 66;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(181, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.sMouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.pictureBox1.Image = global::AniList.Properties.Resources.default_01;
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.sMouseEnter);
            // 
            // watching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "watching";
            this.Size = new System.Drawing.Size(233, 138);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label eps;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ProgressBar progress;
    }
}
