namespace QURAAN_PLAYER
{
    partial class frmAllSurahs
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.soundPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlbody = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.soundPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // soundPicture
            // 
            this.soundPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.soundPicture.Image = global::QURAAN_PLAYER.Properties.Resources.icons8_find_40;
            this.soundPicture.Location = new System.Drawing.Point(970, 13);
            this.soundPicture.Name = "soundPicture";
            this.soundPicture.ShadowDecoration.Parent = this.soundPicture;
            this.soundPicture.Size = new System.Drawing.Size(44, 40);
            this.soundPicture.TabIndex = 4;
            this.soundPicture.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.White;
            this.txtSearch.BorderRadius = 20;
            this.txtSearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(365, 13);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "ابحث عن السورة باستخدام الاسم";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(596, 40);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pnlbody
            // 
            this.pnlbody.AutoScroll = true;
            this.pnlbody.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlbody.Location = new System.Drawing.Point(0, 60);
            this.pnlbody.Name = "pnlbody";
            this.pnlbody.Size = new System.Drawing.Size(1113, 655);
            this.pnlbody.TabIndex = 6;
            this.pnlbody.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlbody_Paint);
            // 
            // frmAllSurahs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1113, 715);
            this.ControlBox = false;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pnlbody);
            this.Controls.Add(this.soundPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAllSurahs";
            this.Load += new System.EventHandler(this.frmAllSurahs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.soundPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2PictureBox soundPicture;
        public Guna.UI2.WinForms.Guna2TextBox txtSearch;
        public System.Windows.Forms.Panel pnlbody;
    }
}