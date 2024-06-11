namespace AniList.UC
{
    partial class watchbutton
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
            this.epsbutton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // epsbutton
            // 
            this.epsbutton.Animated = true;
            this.epsbutton.BorderRadius = 4;
            this.epsbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.epsbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.epsbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.epsbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.epsbutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.epsbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.epsbutton.ForeColor = System.Drawing.Color.Silver;
            this.epsbutton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.epsbutton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.epsbutton.Location = new System.Drawing.Point(0, 0);
            this.epsbutton.Margin = new System.Windows.Forms.Padding(0);
            this.epsbutton.Name = "epsbutton";
            this.epsbutton.Padding = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.epsbutton.Size = new System.Drawing.Size(70, 70);
            this.epsbutton.TabIndex = 52;
            this.epsbutton.Text = "10";
            this.epsbutton.Click += new System.EventHandler(this.epsbutton_Click);
            // 
            // watchbutton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.epsbutton);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "watchbutton";
            this.Size = new System.Drawing.Size(70, 70);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button epsbutton;
    }
}
