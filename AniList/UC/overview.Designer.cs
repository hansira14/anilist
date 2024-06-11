namespace AniList.UC
{
    partial class overview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(overview));
            this.related = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.review = new ScrollableTextBox();
            this.synopsiss = new ScrollableTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // related
            // 
            this.related.AcceptsTab = true;
            this.related.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.related.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.related.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.related.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.related.Location = new System.Drawing.Point(0, 0);
            this.related.Name = "related";
            this.related.ReadOnly = true;
            this.related.RightMargin = 686;
            this.related.Size = new System.Drawing.Size(706, 322);
            this.related.TabIndex = 56;
            this.related.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.related);
            this.panel1.Location = new System.Drawing.Point(38, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 322);
            this.panel1.TabIndex = 56;
            // 
            // review
            // 
            this.review.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.review.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.review.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.review.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.review.Location = new System.Drawing.Point(38, 791);
            this.review.Margin = new System.Windows.Forms.Padding(38, 10, 0, 0);
            this.review.Multiline = true;
            this.review.Name = "review";
            this.review.ReadOnly = true;
            this.review.Size = new System.Drawing.Size(687, 149);
            this.review.TabIndex = 57;
            this.review.Text = resources.GetString("review.Text");
            // 
            // synopsiss
            // 
            this.synopsiss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.synopsiss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.synopsiss.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.synopsiss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.synopsiss.Location = new System.Drawing.Point(38, 66);
            this.synopsiss.Margin = new System.Windows.Forms.Padding(38, 10, 0, 0);
            this.synopsiss.Multiline = true;
            this.synopsiss.Name = "synopsiss";
            this.synopsiss.ReadOnly = true;
            this.synopsiss.Size = new System.Drawing.Size(687, 318);
            this.synopsiss.TabIndex = 46;
            this.synopsiss.Text = resources.GetString("synopsiss.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 58;
            this.label1.Text = "Synopsis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.label2.Location = new System.Drawing.Point(34, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 59;
            this.label2.Text = "Related Anime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.label3.Location = new System.Drawing.Point(34, 760);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 60;
            this.label3.Text = "Reviews";
            // 
            // overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.review);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.synopsiss);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "overview";
            this.Size = new System.Drawing.Size(753, 970);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ScrollableTextBox synopsiss;
        private System.Windows.Forms.RichTextBox related;
        private System.Windows.Forms.Panel panel1;
        private ScrollableTextBox review;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
