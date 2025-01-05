namespace QURAAN_PLAYER
{
    partial class frmmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.pnlControlBox = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFavorite = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnAllSong = new Guna.UI2.WinForms.Guna2Button();
            this.btnAllReaders = new Guna.UI2.WinForms.Guna2Button();
            this.btnADDSURAT = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ctrlPlayPauseMusic1 = new QURAAN_PLAYER.ctrlPlayPauseMusic();
            this.pnlControlBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControlBox
            // 
            this.pnlControlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlControlBox.Controls.Add(this.btnMinimize);
            this.pnlControlBox.Controls.Add(this.btnMaximize);
            this.pnlControlBox.Controls.Add(this.label1);
            this.pnlControlBox.Controls.Add(this.btnCancel);
            this.pnlControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControlBox.Location = new System.Drawing.Point(0, 0);
            this.pnlControlBox.Name = "pnlControlBox";
            this.pnlControlBox.Size = new System.Drawing.Size(1402, 36);
            this.pnlControlBox.TabIndex = 0;
            this.pnlControlBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlControlBox_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(601, 5);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(239, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "أَعُوذُ بِاللَّهِ مِنَ ٱلشَّيْطَانِ ٱلرَّجِيمِ";
            // 
            // pnlBody
            // 
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 36);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1114, 751);
            this.pnlBody.TabIndex = 4;
            this.pnlBody.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBody_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ctrlPlayPauseMusic1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 787);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1402, 55);
            this.panel1.TabIndex = 2;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.pictureBox2);
            this.guna2ShadowPanel1.Controls.Add(this.pictureBox1);
            this.guna2ShadowPanel1.Controls.Add(this.label3);
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.btnFavorite);
            this.guna2ShadowPanel1.Controls.Add(this.btnHome);
            this.guna2ShadowPanel1.Controls.Add(this.btnAllSong);
            this.guna2ShadowPanel1.Controls.Add(this.btnAllReaders);
            this.guna2ShadowPanel1.Controls.Add(this.btnADDSURAT);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ShadowPanel1.EdgeWidth = 10;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(1114, 36);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(56)))), ((int)(((byte)(0)))));
            this.guna2ShadowPanel1.ShadowShift = 10;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(288, 751);
            this.guna2ShadowPanel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(139, 399);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(100, 45);
            this.label3.TabIndex = 8;
            this.label3.Text = "المكتبة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(143, 24);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(96, 45);
            this.label2.TabIndex = 7;
            this.label2.Text = "القائمة";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(245, 416);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(245, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnFavorite
            // 
            this.btnFavorite.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(56)))), ((int)(((byte)(0)))));
            this.btnFavorite.BorderRadius = 20;
            this.btnFavorite.BorderThickness = 1;
            this.btnFavorite.CheckedState.Parent = this.btnFavorite;
            this.btnFavorite.CustomImages.Parent = this.btnFavorite;
            this.btnFavorite.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnFavorite.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavorite.ForeColor = System.Drawing.Color.White;
            this.btnFavorite.HoverState.Parent = this.btnFavorite;
            this.btnFavorite.Image = global::QURAAN_PLAYER.Properties.Resources.icons8_favorite_40;
            this.btnFavorite.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnFavorite.ImageSize = new System.Drawing.Size(40, 40);
            this.btnFavorite.Location = new System.Drawing.Point(21, 263);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnFavorite.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnFavorite.ShadowDecoration.Parent = this.btnFavorite;
            this.btnFavorite.Size = new System.Drawing.Size(255, 45);
            this.btnFavorite.TabIndex = 6;
            this.btnFavorite.Text = "المفضلة";
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // btnHome
            // 
            this.btnHome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(56)))), ((int)(((byte)(0)))));
            this.btnHome.BorderRadius = 20;
            this.btnHome.BorderThickness = 1;
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Image = global::QURAAN_PLAYER.Properties.Resources.icons8_home_40;
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnHome.ImageSize = new System.Drawing.Size(40, 40);
            this.btnHome.Location = new System.Drawing.Point(21, 91);
            this.btnHome.Name = "btnHome";
            this.btnHome.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnHome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(255, 45);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "الرئيسية";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAllSong
            // 
            this.btnAllSong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(56)))), ((int)(((byte)(0)))));
            this.btnAllSong.BorderRadius = 20;
            this.btnAllSong.BorderThickness = 1;
            this.btnAllSong.CheckedState.Parent = this.btnAllSong;
            this.btnAllSong.CustomImages.Parent = this.btnAllSong;
            this.btnAllSong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnAllSong.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllSong.ForeColor = System.Drawing.Color.White;
            this.btnAllSong.HoverState.Parent = this.btnAllSong;
            this.btnAllSong.Image = global::QURAAN_PLAYER.Properties.Resources.icons8_play_record_40;
            this.btnAllSong.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAllSong.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAllSong.Location = new System.Drawing.Point(17, 473);
            this.btnAllSong.Name = "btnAllSong";
            this.btnAllSong.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnAllSong.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAllSong.ShadowDecoration.Parent = this.btnAllSong;
            this.btnAllSong.Size = new System.Drawing.Size(255, 45);
            this.btnAllSong.TabIndex = 4;
            this.btnAllSong.Text = "كل السور";
            this.btnAllSong.Click += new System.EventHandler(this.btnAllSong_Click);
            // 
            // btnAllReaders
            // 
            this.btnAllReaders.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(56)))), ((int)(((byte)(0)))));
            this.btnAllReaders.BorderRadius = 20;
            this.btnAllReaders.BorderThickness = 1;
            this.btnAllReaders.CheckedState.Parent = this.btnAllReaders;
            this.btnAllReaders.CustomImages.Parent = this.btnAllReaders;
            this.btnAllReaders.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnAllReaders.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllReaders.ForeColor = System.Drawing.Color.White;
            this.btnAllReaders.HoverState.Parent = this.btnAllReaders;
            this.btnAllReaders.Image = global::QURAAN_PLAYER.Properties.Resources.icons8_muslim_40;
            this.btnAllReaders.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAllReaders.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAllReaders.Location = new System.Drawing.Point(17, 542);
            this.btnAllReaders.Name = "btnAllReaders";
            this.btnAllReaders.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnAllReaders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAllReaders.ShadowDecoration.Parent = this.btnAllReaders;
            this.btnAllReaders.Size = new System.Drawing.Size(255, 45);
            this.btnAllReaders.TabIndex = 5;
            this.btnAllReaders.Text = "كل المقرئين";
            this.btnAllReaders.Click += new System.EventHandler(this.btnAllReaders_Click);
            // 
            // btnADDSURAT
            // 
            this.btnADDSURAT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(56)))), ((int)(((byte)(0)))));
            this.btnADDSURAT.BorderRadius = 20;
            this.btnADDSURAT.BorderThickness = 1;
            this.btnADDSURAT.CheckedState.Parent = this.btnADDSURAT;
            this.btnADDSURAT.CustomImages.Parent = this.btnADDSURAT;
            this.btnADDSURAT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnADDSURAT.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADDSURAT.ForeColor = System.Drawing.Color.White;
            this.btnADDSURAT.HoverState.Parent = this.btnADDSURAT;
            this.btnADDSURAT.Image = global::QURAAN_PLAYER.Properties.Resources.icons8_add_song_40;
            this.btnADDSURAT.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnADDSURAT.ImageSize = new System.Drawing.Size(40, 40);
            this.btnADDSURAT.Location = new System.Drawing.Point(21, 183);
            this.btnADDSURAT.Name = "btnADDSURAT";
            this.btnADDSURAT.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnADDSURAT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnADDSURAT.ShadowDecoration.Parent = this.btnADDSURAT;
            this.btnADDSURAT.Size = new System.Drawing.Size(255, 45);
            this.btnADDSURAT.TabIndex = 2;
            this.btnADDSURAT.Text = "إضافة قرائة";
            this.btnADDSURAT.Click += new System.EventHandler(this.btnADDSURAT_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::QURAAN_PLAYER.Properties.Resources.icons8_line_24;
            this.btnMinimize.Location = new System.Drawing.Point(1267, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 36);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::QURAAN_PLAYER.Properties.Resources.icons8_maximize_button_20;
            this.btnMaximize.Location = new System.Drawing.Point(1312, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(45, 36);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.maximize_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::QURAAN_PLAYER.Properties.Resources.icons8_cancel_20;
            this.btnCancel.Location = new System.Drawing.Point(1357, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(45, 36);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ctrlPlayPauseMusic1
            // 
            this.ctrlPlayPauseMusic1.Location = new System.Drawing.Point(3, 2);
            this.ctrlPlayPauseMusic1.Name = "ctrlPlayPauseMusic1";
            this.ctrlPlayPauseMusic1.Size = new System.Drawing.Size(1410, 47);
            this.ctrlPlayPauseMusic1.TabIndex = 0;
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1402, 842);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlControlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.pnlControlBox.ResumeLayout(false);
            this.pnlControlBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControlBox;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        public Guna.UI2.WinForms.Guna2Button btnHome;
        public Guna.UI2.WinForms.Guna2Button btnADDSURAT;
        public Guna.UI2.WinForms.Guna2Button btnFavorite;
        public Guna.UI2.WinForms.Guna2Button btnAllReaders;
        public Guna.UI2.WinForms.Guna2Button btnAllSong;
        private System.Windows.Forms.Panel pnlBody;
        private ctrlPlayPauseMusic ctrlPlayPauseMusic1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

