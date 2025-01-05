namespace QURAAN_PLAYER
{
    partial class frmHome
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
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlRecommandation = new System.Windows.Forms.Panel();
            this.pnlJumper = new System.Windows.Forms.Panel();
            this.lblRecoma = new System.Windows.Forms.Label();
            this.pnlReaderAndSuratInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblreader = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSuggetionSuar = new System.Windows.Forms.Panel();
            this.pnlRelatedSurat = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnScrolRight = new System.Windows.Forms.Button();
            this.btnLeftscrol = new System.Windows.Forms.Button();
            this.soundPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlRecommandation.SuspendLayout();
            this.pnlReaderAndSuratInfo.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soundPicture)).BeginInit();
            this.SuspendLayout();
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
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(413, 4);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "ابحث عن السورة باستخدام الاسم";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(596, 40);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pnlRecommandation
            // 
            this.pnlRecommandation.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.pnlRecommandation.Controls.Add(this.pnlJumper);
            this.pnlRecommandation.Location = new System.Drawing.Point(375, 108);
            this.pnlRecommandation.Name = "pnlRecommandation";
            this.pnlRecommandation.Size = new System.Drawing.Size(711, 241);
            this.pnlRecommandation.TabIndex = 3;
            // 
            // pnlJumper
            // 
            this.pnlJumper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(56)))), ((int)(((byte)(0)))));
            this.pnlJumper.CausesValidation = false;
            this.pnlJumper.Location = new System.Drawing.Point(30, 213);
            this.pnlJumper.Name = "pnlJumper";
            this.pnlJumper.Size = new System.Drawing.Size(200, 5);
            this.pnlJumper.TabIndex = 0;
            // 
            // lblRecoma
            // 
            this.lblRecoma.AutoSize = true;
            this.lblRecoma.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecoma.ForeColor = System.Drawing.Color.White;
            this.lblRecoma.Location = new System.Drawing.Point(879, 70);
            this.lblRecoma.Name = "lblRecoma";
            this.lblRecoma.Size = new System.Drawing.Size(199, 35);
            this.lblRecoma.TabIndex = 4;
            this.lblRecoma.Text = "اقتراحات  المقرئين";
            // 
            // pnlReaderAndSuratInfo
            // 
            this.pnlReaderAndSuratInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.pnlReaderAndSuratInfo.BorderRadius = 40;
            this.pnlReaderAndSuratInfo.Controls.Add(this.label2);
            this.pnlReaderAndSuratInfo.Controls.Add(this.label1);
            this.pnlReaderAndSuratInfo.Controls.Add(this.lblNumber);
            this.pnlReaderAndSuratInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.pnlReaderAndSuratInfo.Location = new System.Drawing.Point(19, 108);
            this.pnlReaderAndSuratInfo.Name = "pnlReaderAndSuratInfo";
            this.pnlReaderAndSuratInfo.ShadowDecoration.Parent = this.pnlReaderAndSuratInfo;
            this.pnlReaderAndSuratInfo.Size = new System.Drawing.Size(315, 132);
            this.pnlReaderAndSuratInfo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 77);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = " | روايةحفص عن عاصم";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(220, 77);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "سور";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblNumber.ForeColor = System.Drawing.Color.White;
            this.lblNumber.Location = new System.Drawing.Point(264, 77);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNumber.Size = new System.Drawing.Size(24, 25);
            this.lblNumber.TabIndex = 12;
            this.lblNumber.Text = "9";
            // 
            // lblreader
            // 
            this.lblreader.AutoSize = true;
            this.lblreader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.lblreader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreader.ForeColor = System.Drawing.Color.White;
            this.lblreader.Location = new System.Drawing.Point(121, 17);
            this.lblreader.Name = "lblreader";
            this.lblreader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblreader.Size = new System.Drawing.Size(82, 39);
            this.lblreader.TabIndex = 11;
            this.lblreader.Text = "الشيخ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(942, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "سور مقترحة";
            // 
            // pnlSuggetionSuar
            // 
            this.pnlSuggetionSuar.AutoScroll = true;
            this.pnlSuggetionSuar.Location = new System.Drawing.Point(375, 414);
            this.pnlSuggetionSuar.Name = "pnlSuggetionSuar";
            this.pnlSuggetionSuar.Size = new System.Drawing.Size(711, 320);
            this.pnlSuggetionSuar.TabIndex = 10;
            // 
            // pnlRelatedSurat
            // 
            this.pnlRelatedSurat.BackColor = System.Drawing.Color.Transparent;
            this.pnlRelatedSurat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.pnlRelatedSurat.Location = new System.Drawing.Point(6, 127);
            this.pnlRelatedSurat.Name = "pnlRelatedSurat";
            this.pnlRelatedSurat.Radius = 30;
            this.pnlRelatedSurat.ShadowColor = System.Drawing.Color.Black;
            this.pnlRelatedSurat.Size = new System.Drawing.Size(342, 575);
            this.pnlRelatedSurat.TabIndex = 11;
            this.pnlRelatedSurat.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRelatedSurat_Paint);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.guna2Panel1.BorderRadius = 40;
            this.guna2Panel1.Controls.Add(this.lblreader);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.guna2Panel1.Location = new System.Drawing.Point(19, 95);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(315, 87);
            this.guna2Panel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.panel1.Location = new System.Drawing.Point(-5, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 73);
            this.panel1.TabIndex = 1;
            // 
            // btnScrolRight
            // 
            this.btnScrolRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScrolRight.Image = global::QURAAN_PLAYER.Properties.Resources.icons8_double_right_20;
            this.btnScrolRight.Location = new System.Drawing.Point(422, 70);
            this.btnScrolRight.Name = "btnScrolRight";
            this.btnScrolRight.Size = new System.Drawing.Size(41, 32);
            this.btnScrolRight.TabIndex = 6;
            this.btnScrolRight.UseVisualStyleBackColor = true;
            this.btnScrolRight.Click += new System.EventHandler(this.btnScrolRight_Click);
            // 
            // btnLeftscrol
            // 
            this.btnLeftscrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftscrol.Image = global::QURAAN_PLAYER.Properties.Resources.icons8_double_left_20;
            this.btnLeftscrol.Location = new System.Drawing.Point(375, 70);
            this.btnLeftscrol.Name = "btnLeftscrol";
            this.btnLeftscrol.Size = new System.Drawing.Size(41, 32);
            this.btnLeftscrol.TabIndex = 5;
            this.btnLeftscrol.UseVisualStyleBackColor = true;
            this.btnLeftscrol.Click += new System.EventHandler(this.btnLeftscrol_Click);
            // 
            // soundPicture
            // 
            this.soundPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.soundPicture.Image = global::QURAAN_PLAYER.Properties.Resources.icons8_find_40;
            this.soundPicture.Location = new System.Drawing.Point(1018, 4);
            this.soundPicture.Name = "soundPicture";
            this.soundPicture.ShadowDecoration.Parent = this.soundPicture;
            this.soundPicture.Size = new System.Drawing.Size(44, 40);
            this.soundPicture.TabIndex = 2;
            this.soundPicture.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1113, 746);
            this.ControlBox = false;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pnlReaderAndSuratInfo);
            this.Controls.Add(this.pnlRelatedSurat);
            this.Controls.Add(this.pnlSuggetionSuar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnScrolRight);
            this.Controls.Add(this.btnLeftscrol);
            this.Controls.Add(this.lblRecoma);
            this.Controls.Add(this.pnlRecommandation);
            this.Controls.Add(this.soundPicture);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmHome";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.pnlRecommandation.ResumeLayout(false);
            this.pnlReaderAndSuratInfo.ResumeLayout(false);
            this.pnlReaderAndSuratInfo.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soundPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2PictureBox soundPicture;
        private System.Windows.Forms.Panel pnlRecommandation;
        private System.Windows.Forms.Label lblRecoma;
        private System.Windows.Forms.Button btnLeftscrol;
        private System.Windows.Forms.Button btnScrolRight;
        private System.Windows.Forms.Panel pnlJumper;
        private Guna.UI2.WinForms.Guna2Panel pnlReaderAndSuratInfo;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblreader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlSuggetionSuar;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlRelatedSurat;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel panel1;
    }
}