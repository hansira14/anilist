namespace AniList.UC
{
    partial class historylog
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
            this.here = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.here.SuspendLayout();
            this.SuspendLayout();
            // 
            // here
            // 
            this.here.AutoScroll = true;
            this.here.Controls.Add(this.label4);
            this.here.Location = new System.Drawing.Point(0, 0);
            this.here.Name = "here";
            this.here.Padding = new System.Windows.Forms.Padding(20);
            this.here.Size = new System.Drawing.Size(1113, 762);
            this.here.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(189)))));
            this.label4.Location = new System.Drawing.Point(20, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.label4.Size = new System.Drawing.Size(1094, 41);
            this.label4.TabIndex = 94;
            this.label4.Text = "Activity History";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // historylog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.here);
            this.Name = "historylog";
            this.Size = new System.Drawing.Size(1066, 762);
            this.here.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel here;
        private System.Windows.Forms.Label label4;
    }
}
