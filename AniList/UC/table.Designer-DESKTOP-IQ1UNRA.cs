namespace AniList.UC
{
    partial class table
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
            this.panel = new System.Windows.Forms.Panel();
            this.prev = new Guna.UI2.WinForms.Guna2CircleButton();
            this.next = new Guna.UI2.WinForms.Guna2CircleButton();
            this.tablee = new System.Windows.Forms.TableLayoutPanel();
            this.list = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.prev);
            this.panel.Controls.Add(this.next);
            this.panel.Controls.Add(this.tablee);
            this.panel.Controls.Add(this.list);
            this.panel.Location = new System.Drawing.Point(10, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1056, 205);
            this.panel.TabIndex = 2;
            this.panel.MouseEnter += new System.EventHandler(this.tablee_MouseEnter);
            this.panel.MouseLeave += new System.EventHandler(this.tablee_MouseLeave);
            // 
            // prev
            // 
            this.prev.Animated = true;
            this.prev.BackColor = System.Drawing.Color.Transparent;
            this.prev.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.prev.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.prev.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.prev.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.prev.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.prev.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.prev.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prev.ForeColor = System.Drawing.Color.Transparent;
            this.prev.IndicateFocus = true;
            this.prev.Location = new System.Drawing.Point(14, 103);
            this.prev.Name = "prev";
            this.prev.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.prev.Size = new System.Drawing.Size(30, 30);
            this.prev.TabIndex = 34;
            this.prev.UseTransparentBackground = true;
            this.prev.Visible = false;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.Animated = true;
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.next.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.next.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.next.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.next.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.next.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.next.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.next.ForeColor = System.Drawing.Color.Transparent;
            this.next.Location = new System.Drawing.Point(1003, 103);
            this.next.Name = "next";
            this.next.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.next.Size = new System.Drawing.Size(30, 30);
            this.next.TabIndex = 33;
            this.next.UseTransparentBackground = true;
            this.next.Visible = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // tablee
            // 
            this.tablee.AutoSize = true;
            this.tablee.BackColor = System.Drawing.Color.Transparent;
            this.tablee.ColumnCount = 1;
            this.tablee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablee.Location = new System.Drawing.Point(3, 40);
            this.tablee.Name = "tablee";
            this.tablee.RowCount = 1;
            this.tablee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablee.Size = new System.Drawing.Size(1053, 162);
            this.tablee.TabIndex = 32;
            this.tablee.MouseEnter += new System.EventHandler(this.tablee_MouseEnter);
            this.tablee.MouseLeave += new System.EventHandler(this.tablee_MouseLeave);
            // 
            // list
            // 
            this.list.AutoSize = true;
            this.list.Dock = System.Windows.Forms.DockStyle.Top;
            this.list.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.list.Location = new System.Drawing.Point(0, 0);
            this.list.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(106, 37);
            this.list.TabIndex = 27;
            this.list.Text = "Trending";
            this.list.MouseEnter += new System.EventHandler(this.tablee_MouseEnter);
            this.list.MouseLeave += new System.EventHandler(this.tablee_MouseLeave);
            // 
            // table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "table";
            this.Size = new System.Drawing.Size(1066, 205);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private Guna.UI2.WinForms.Guna2CircleButton prev;
        private Guna.UI2.WinForms.Guna2CircleButton next;
        private System.Windows.Forms.TableLayoutPanel tablee;
        private System.Windows.Forms.Label list;
    }
}
