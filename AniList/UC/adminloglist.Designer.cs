namespace AniList.UC
{
    partial class adminloglist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminloglist));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.search = new Guna.UI2.WinForms.Guna2TextBox();
            this.genre = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 56);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1124, 706);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // search
            // 
            this.search.Animated = true;
            this.search.AutoRoundedCorners = true;
            this.search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(46)))));
            this.search.BorderRadius = 17;
            this.search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search.DefaultText = "";
            this.search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(147)))), ((int)(((byte)(98)))));
            this.search.IconLeft = ((System.Drawing.Image)(resources.GetObject("search.IconLeft")));
            this.search.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.search.IconLeftSize = new System.Drawing.Size(15, 15);
            this.search.Location = new System.Drawing.Point(103, 9);
            this.search.Name = "search";
            this.search.PasswordChar = '\0';
            this.search.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(126)))), ((int)(((byte)(129)))));
            this.search.PlaceholderText = " Search users";
            this.search.SelectedText = "";
            this.search.Size = new System.Drawing.Size(256, 36);
            this.search.TabIndex = 14;
            this.search.TextOffset = new System.Drawing.Point(5, 0);
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // genre
            // 
            this.genre.BackColor = System.Drawing.Color.Transparent;
            this.genre.BorderRadius = 4;
            this.genre.BorderThickness = 0;
            this.genre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.genre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.genre.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.genre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.genre.ItemHeight = 30;
            this.genre.Items.AddRange(new object[] {
            "Name asc",
            "Name desc",
            "Username asc",
            "Username desc",
            "Activitydate desc",
            "Activitydate asc"});
            this.genre.Location = new System.Drawing.Point(391, 9);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(190, 36);
            this.genre.TabIndex = 15;
            this.genre.SelectedIndexChanged += new System.EventHandler(this.genre_SelectedIndexChanged);
            // 
            // adminloglist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.genre);
            this.Controls.Add(this.search);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "adminloglist";
            this.Size = new System.Drawing.Size(1097, 762);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public Guna.UI2.WinForms.Guna2TextBox search;
        private Guna.UI2.WinForms.Guna2ComboBox genre;
    }
}
