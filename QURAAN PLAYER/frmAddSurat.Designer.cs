namespace QURAAN_PLAYER
{
    partial class frmAddSurat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddSurat));
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbSurahsAmes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbReaders = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MessageOfAddReader = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlAdd = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lkSearchOnline = new System.Windows.Forms.LinkLabel();
            this.lkDelete = new System.Windows.Forms.LinkLabel();
            this.lkLoadPicture = new System.Windows.Forms.LinkLabel();
            this.btnSaveReader = new Guna.UI2.WinForms.Guna2Button();
            this.Profile = new System.Windows.Forms.PictureBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSecondName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNotification = new System.Windows.Forms.Button();
            this.soundPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GradientPanel3.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(839, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 35);
            this.label3.TabIndex = 10;
            this.label3.Text = "اختر اسم السورة ";
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
            this.txtSearch.Location = new System.Drawing.Point(419, 29);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "ابحث عن السورة باستخدام الاسم";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(596, 41);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            // 
            // cmbSurahsAmes
            // 
            this.cmbSurahsAmes.BackColor = System.Drawing.Color.Transparent;
            this.cmbSurahsAmes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(56)))), ((int)(((byte)(0)))));
            this.cmbSurahsAmes.BorderRadius = 20;
            this.cmbSurahsAmes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSurahsAmes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSurahsAmes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cmbSurahsAmes.FocusedColor = System.Drawing.Color.Empty;
            this.cmbSurahsAmes.FocusedState.Parent = this.cmbSurahsAmes;
            this.cmbSurahsAmes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSurahsAmes.ForeColor = System.Drawing.Color.White;
            this.cmbSurahsAmes.FormattingEnabled = true;
            this.cmbSurahsAmes.HoverState.Parent = this.cmbSurahsAmes;
            this.cmbSurahsAmes.ItemHeight = 30;
            this.cmbSurahsAmes.ItemsAppearance.Parent = this.cmbSurahsAmes;
            this.cmbSurahsAmes.Location = new System.Drawing.Point(643, 168);
            this.cmbSurahsAmes.Name = "cmbSurahsAmes";
            this.cmbSurahsAmes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSurahsAmes.ShadowDecoration.Parent = this.cmbSurahsAmes;
            this.cmbSurahsAmes.Size = new System.Drawing.Size(406, 36);
            this.cmbSurahsAmes.TabIndex = 14;
            // 
            // cmbReaders
            // 
            this.cmbReaders.BackColor = System.Drawing.Color.Transparent;
            this.cmbReaders.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(56)))), ((int)(((byte)(0)))));
            this.cmbReaders.BorderRadius = 20;
            this.cmbReaders.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbReaders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReaders.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cmbReaders.FocusedColor = System.Drawing.Color.Empty;
            this.cmbReaders.FocusedState.Parent = this.cmbReaders;
            this.cmbReaders.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbReaders.ForeColor = System.Drawing.Color.White;
            this.cmbReaders.FormattingEnabled = true;
            this.cmbReaders.HoverState.Parent = this.cmbReaders;
            this.cmbReaders.ItemHeight = 30;
            this.cmbReaders.ItemsAppearance.Parent = this.cmbReaders;
            this.cmbReaders.Location = new System.Drawing.Point(639, 280);
            this.cmbReaders.Name = "cmbReaders";
            this.cmbReaders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbReaders.ShadowDecoration.Parent = this.cmbReaders;
            this.cmbReaders.Size = new System.Drawing.Size(406, 36);
            this.cmbReaders.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(713, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 35);
            this.label1.TabIndex = 15;
            this.label1.Text = "اختر المقرئ من القائمة التالية";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 30;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(61)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(47, 67);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(474, 50);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "تحميل الصوت،من ملفاتك";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 30;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(61)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(47, 182);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(464, 50);
            this.guna2Button1.TabIndex = 21;
            this.guna2Button1.Text = "تصفح الانترنت";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2GradientPanel3
            // 
            this.guna2GradientPanel3.BackColor = System.Drawing.Color.Black;
            this.guna2GradientPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(56)))), ((int)(((byte)(0)))));
            this.guna2GradientPanel3.BorderRadius = 30;
            this.guna2GradientPanel3.BorderThickness = 6;
            this.guna2GradientPanel3.Controls.Add(this.label5);
            this.guna2GradientPanel3.Controls.Add(this.guna2Button1);
            this.guna2GradientPanel3.Controls.Add(this.label4);
            this.guna2GradientPanel3.Controls.Add(this.label2);
            this.guna2GradientPanel3.Controls.Add(this.btnAdd);
            this.guna2GradientPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.guna2GradientPanel3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.guna2GradientPanel3.Location = new System.Drawing.Point(37, 162);
            this.guna2GradientPanel3.Name = "guna2GradientPanel3";
            this.guna2GradientPanel3.ShadowDecoration.Parent = this.guna2GradientPanel3;
            this.guna2GradientPanel3.Size = new System.Drawing.Size(530, 266);
            this.guna2GradientPanel3.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(153, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(324, 35);
            this.label5.TabIndex = 20;
            this.label5.Text = "لو لم تحمل الصوت ،المنشود بعد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(224, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 35);
            this.label4.TabIndex = 19;
            this.label4.Text = "MP3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(293, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 35);
            this.label2.TabIndex = 18;
            this.label2.Text = "ان كنت تملك المقطع ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(56)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(740, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 35);
            this.label6.TabIndex = 24;
            this.label6.Text = "لم تجده؟لا بأس اضفه من هنا";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.Black;
            this.pnlAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(56)))), ((int)(((byte)(0)))));
            this.pnlAdd.BorderRadius = 30;
            this.pnlAdd.BorderThickness = 6;
            this.pnlAdd.Controls.Add(this.lkSearchOnline);
            this.pnlAdd.Controls.Add(this.lkDelete);
            this.pnlAdd.Controls.Add(this.lkLoadPicture);
            this.pnlAdd.Controls.Add(this.btnSaveReader);
            this.pnlAdd.Controls.Add(this.Profile);
            this.pnlAdd.Controls.Add(this.txtLastName);
            this.pnlAdd.Controls.Add(this.txtSecondName);
            this.pnlAdd.Controls.Add(this.txtFirstName);
            this.pnlAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlAdd.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlAdd.Location = new System.Drawing.Point(37, 450);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.ShadowDecoration.Parent = this.pnlAdd;
            this.pnlAdd.Size = new System.Drawing.Size(1031, 216);
            this.pnlAdd.TabIndex = 26;
            this.pnlAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint);
            // 
            // lkSearchOnline
            // 
            this.lkSearchOnline.AutoSize = true;
            this.lkSearchOnline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lkSearchOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkSearchOnline.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(56)))), ((int)(((byte)(0)))));
            this.lkSearchOnline.Location = new System.Drawing.Point(224, 143);
            this.lkSearchOnline.Name = "lkSearchOnline";
            this.lkSearchOnline.Size = new System.Drawing.Size(108, 31);
            this.lkSearchOnline.TabIndex = 27;
            this.lkSearchOnline.TabStop = true;
            this.lkSearchOnline.Text = "ابحث اولا";
            this.lkSearchOnline.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkSearchOnline_LinkClicked);
            // 
            // lkDelete
            // 
            this.lkDelete.AutoSize = true;
            this.lkDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lkDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkDelete.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(56)))), ((int)(((byte)(0)))));
            this.lkDelete.Location = new System.Drawing.Point(209, 86);
            this.lkDelete.Name = "lkDelete";
            this.lkDelete.Size = new System.Drawing.Size(129, 31);
            this.lkDelete.TabIndex = 26;
            this.lkDelete.TabStop = true;
            this.lkDelete.Text = "حذف صورة";
            this.lkDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkDelete_LinkClicked);
            // 
            // lkLoadPicture
            // 
            this.lkLoadPicture.AutoSize = true;
            this.lkLoadPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lkLoadPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkLoadPicture.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(56)))), ((int)(((byte)(0)))));
            this.lkLoadPicture.Location = new System.Drawing.Point(209, 27);
            this.lkLoadPicture.Name = "lkLoadPicture";
            this.lkLoadPicture.Size = new System.Drawing.Size(138, 31);
            this.lkLoadPicture.TabIndex = 25;
            this.lkLoadPicture.TabStop = true;
            this.lkLoadPicture.Text = "حمل الصورة";
            this.lkLoadPicture.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkLoadPicture_LinkClicked);
            // 
            // btnSaveReader
            // 
            this.btnSaveReader.BorderRadius = 30;
            this.btnSaveReader.CheckedState.Parent = this.btnSaveReader;
            this.btnSaveReader.CustomBorderColor = System.Drawing.Color.White;
            this.btnSaveReader.CustomImages.Parent = this.btnSaveReader;
            this.btnSaveReader.Enabled = false;
            this.btnSaveReader.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveReader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveReader.ForeColor = System.Drawing.Color.White;
            this.btnSaveReader.HoverState.Parent = this.btnSaveReader;
            this.btnSaveReader.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveReader.Image")));
            this.btnSaveReader.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSaveReader.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSaveReader.Location = new System.Drawing.Point(24, 86);
            this.btnSaveReader.Name = "btnSaveReader";
            this.btnSaveReader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSaveReader.ShadowDecoration.Parent = this.btnSaveReader;
            this.btnSaveReader.Size = new System.Drawing.Size(124, 47);
            this.btnSaveReader.TabIndex = 24;
            this.btnSaveReader.Text = "حفظ";
            this.btnSaveReader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSaveReader.Click += new System.EventHandler(this.btnSaveReader_Click);
            // 
            // Profile
            // 
            this.Profile.Image = global::QURAAN_PLAYER.Properties.Resources.voidpicture;
            this.Profile.Location = new System.Drawing.Point(353, 18);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(204, 184);
            this.Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Profile.TabIndex = 15;
            this.Profile.TabStop = false;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderColor = System.Drawing.Color.White;
            this.txtLastName.BorderRadius = 20;
            this.txtLastName.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.Parent = this.txtLastName;
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.FocusedState.Parent = this.txtLastName;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.White;
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.HoverState.Parent = this.txtLastName;
            this.txtLastName.Location = new System.Drawing.Point(588, 143);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderText = "الاسم العائلي";
            this.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLastName.SelectedText = "";
            this.txtLastName.ShadowDecoration.Parent = this.txtLastName;
            this.txtLastName.Size = new System.Drawing.Size(406, 41);
            this.txtLastName.TabIndex = 14;
            this.txtLastName.Tag = "3";
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            this.txtLastName.Leave += new System.EventHandler(this.txtLastName_Leave);
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.pnlAdd_Validating);
            // 
            // txtSecondName
            // 
            this.txtSecondName.BorderColor = System.Drawing.Color.White;
            this.txtSecondName.BorderRadius = 20;
            this.txtSecondName.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtSecondName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSecondName.DefaultText = "";
            this.txtSecondName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSecondName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSecondName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSecondName.DisabledState.Parent = this.txtSecondName;
            this.txtSecondName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSecondName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtSecondName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSecondName.FocusedState.Parent = this.txtSecondName;
            this.txtSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondName.ForeColor = System.Drawing.Color.White;
            this.txtSecondName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSecondName.HoverState.Parent = this.txtSecondName;
            this.txtSecondName.Location = new System.Drawing.Point(588, 77);
            this.txtSecondName.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.PasswordChar = '\0';
            this.txtSecondName.PlaceholderText = "الاسم االثاني(اختياري)";
            this.txtSecondName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSecondName.SelectedText = "";
            this.txtSecondName.ShadowDecoration.Parent = this.txtSecondName;
            this.txtSecondName.Size = new System.Drawing.Size(406, 41);
            this.txtSecondName.TabIndex = 13;
            this.txtSecondName.Tag = "2";
            this.txtSecondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            this.txtSecondName.Leave += new System.EventHandler(this.txtLastName_Leave);
            this.txtSecondName.Validating += new System.ComponentModel.CancelEventHandler(this.guna2TextBox1_Validating);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderColor = System.Drawing.Color.White;
            this.txtFirstName.BorderRadius = 20;
            this.txtFirstName.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.Parent = this.txtFirstName;
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.FocusedState.Parent = this.txtFirstName;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.White;
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.HoverState.Parent = this.txtFirstName;
            this.txtFirstName.Location = new System.Drawing.Point(588, 18);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderText = "الاسم الاول";
            this.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.ShadowDecoration.Parent = this.txtFirstName;
            this.txtFirstName.Size = new System.Drawing.Size(406, 41);
            this.txtFirstName.TabIndex = 12;
            this.txtFirstName.Tag = "1";
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            this.txtFirstName.Leave += new System.EventHandler(this.txtLastName_Leave);
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.pnlAdd_Validating);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            this.error.RightToLeft = true;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 30;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomBorderColor = System.Drawing.Color.White;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.Enabled = false;
            this.btnSave.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSave.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSave.Location = new System.Drawing.Point(37, 87);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(171, 50);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 30;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomBorderColor = System.Drawing.Color.White;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnCancel.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCancel.Location = new System.Drawing.Point(37, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(171, 50);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(253, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 45);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNotification
            // 
            this.btnNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotification.Image = ((System.Drawing.Image)(resources.GetObject("btnNotification.Image")));
            this.btnNotification.Location = new System.Drawing.Point(336, 25);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(48, 45);
            this.btnNotification.TabIndex = 13;
            this.btnNotification.UseVisualStyleBackColor = true;
            // 
            // soundPicture
            // 
            this.soundPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.soundPicture.Image = ((System.Drawing.Image)(resources.GetObject("soundPicture.Image")));
            this.soundPicture.Location = new System.Drawing.Point(1024, 29);
            this.soundPicture.Name = "soundPicture";
            this.soundPicture.ShadowDecoration.Parent = this.soundPicture;
            this.soundPicture.Size = new System.Drawing.Size(44, 41);
            this.soundPicture.TabIndex = 12;
            this.soundPicture.TabStop = false;
            // 
            // frmAddSurat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1099, 678);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2GradientPanel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbReaders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSurahsAmes);
            this.Controls.Add(this.btnNotification);
            this.Controls.Add(this.soundPicture);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddSurat";
            this.Load += new System.EventHandler(this.frmAddSurat_Load);
            this.guna2GradientPanel3.ResumeLayout(false);
            this.guna2GradientPanel3.PerformLayout();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox soundPicture;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Button btnNotification;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSurahsAmes;
        private Guna.UI2.WinForms.Guna2ComboBox cmbReaders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip MessageOfAddReader;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlAdd;
        private System.Windows.Forms.PictureBox Profile;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtSecondName;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2Button btnSaveReader;
        private System.Windows.Forms.LinkLabel lkDelete;
        private System.Windows.Forms.LinkLabel lkLoadPicture;
        private System.Windows.Forms.LinkLabel lkSearchOnline;
        private System.Windows.Forms.ErrorProvider error;
    }
}