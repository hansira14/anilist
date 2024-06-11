namespace AniList.UC
{
    partial class tableUpcoming
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
            this.header = new System.Windows.Forms.Label();
            this.seemore = new Guna.UI2.WinForms.Guna2Button();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.header.Location = new System.Drawing.Point(25, 16);
            this.header.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(106, 37);
            this.header.TabIndex = 28;
            this.header.Text = "Trending";
            // 
            // seemore
            // 
            this.seemore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seemore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.seemore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.seemore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.seemore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.seemore.FillColor = System.Drawing.Color.Transparent;
            this.seemore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seemore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.seemore.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.seemore.HoverState.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seemore.Location = new System.Drawing.Point(853, 16);
            this.seemore.Name = "seemore";
            this.seemore.Size = new System.Drawing.Size(150, 37);
            this.seemore.TabIndex = 36;
            this.seemore.Text = "See more...";
            this.seemore.Click += new System.EventHandler(this.seemore_Click_1);
            // 
            // table
            // 
            this.table.AutoSize = true;
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.Location = new System.Drawing.Point(31, 58);
            this.table.Name = "table";
            this.table.RowCount = 2;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.Size = new System.Drawing.Size(360, 258);
            this.table.TabIndex = 37;
            // 
            // table5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.table);
            this.Controls.Add(this.header);
            this.Controls.Add(this.seemore);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.Name = "table5";
            this.Size = new System.Drawing.Size(1066, 657);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private Guna.UI2.WinForms.Guna2Button seemore;
        public System.Windows.Forms.TableLayoutPanel table;
    }
}
