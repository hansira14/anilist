namespace AniList
{
    partial class animeMylist
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
            this.title = new System.Windows.Forms.Label();
            this.yourscore = new System.Windows.Forms.Label();
            this.rating = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stat = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.title.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.LightGray;
            this.title.Location = new System.Drawing.Point(99, 30);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(407, 19);
            this.title.TabIndex = 9;
            this.title.Text = "123456789012345567890123456789012345678901234566790";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // yourscore
            // 
            this.yourscore.AutoSize = true;
            this.yourscore.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.yourscore.ForeColor = System.Drawing.Color.LightGray;
            this.yourscore.Location = new System.Drawing.Point(641, 30);
            this.yourscore.Name = "yourscore";
            this.yourscore.Size = new System.Drawing.Size(47, 19);
            this.yourscore.TabIndex = 17;
            this.yourscore.Text = "label2";
            // 
            // rating
            // 
            this.rating.AutoSize = true;
            this.rating.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(191)))), ((int)(((byte)(102)))));
            this.rating.Location = new System.Drawing.Point(534, 30);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(37, 19);
            this.rating.TabIndex = 11;
            this.rating.Text = "9.03";
            this.rating.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progress
            // 
            this.progress.AutoSize = true;
            this.progress.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.progress.ForeColor = System.Drawing.Color.LightGray;
            this.progress.Location = new System.Drawing.Point(758, 30);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(47, 19);
            this.progress.TabIndex = 18;
            this.progress.Text = "label4";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(115)))), ((int)(((byte)(82)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(16, 16);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(50, 50);
            this.panel3.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::AniList.Properties.Resources.default_01;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // stat
            // 
            this.stat.AutoSize = true;
            this.stat.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.stat.ForeColor = System.Drawing.Color.LightGray;
            this.stat.Location = new System.Drawing.Point(875, 30);
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(47, 19);
            this.stat.TabIndex = 19;
            this.stat.Text = "label5";
            // 
            // anime3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.stat);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.yourscore);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.rating);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "anime3";
            this.Size = new System.Drawing.Size(1066, 77);
            this.Load += new System.EventHandler(this.anime_Load);
            this.Leave += new System.EventHandler(this.anime2_Leave);
            this.MouseEnter += new System.EventHandler(this.anime3_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.anime3_MouseLeave);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label yourscore;
        private System.Windows.Forms.Label rating;
        private System.Windows.Forms.Label progress;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label stat;
    }
}
