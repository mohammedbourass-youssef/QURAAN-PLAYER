namespace QURAAN_PLAYER
{
    partial class ctrlPlayPauseMusic
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlPlayPauseMusic));
            this.BarController = new System.Windows.Forms.Timer(this.components);
            this.SoundLevelCheck = new System.Windows.Forms.Timer(this.components);
            this.pnlPlayer = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPlayer = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblTimeCounter = new System.Windows.Forms.Label();
            this.lblMAXTime = new System.Windows.Forms.Label();
            this.bar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.soundPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.SoundController = new Guna.UI2.WinForms.Guna2TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soundPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BarController
            // 
            this.BarController.Interval = 1000;
            this.BarController.Tick += new System.EventHandler(this.BarController_Tick_1);
            // 
            // SoundLevelCheck
            // 
            this.SoundLevelCheck.Enabled = true;
            this.SoundLevelCheck.Interval = 10;
            this.SoundLevelCheck.Tick += new System.EventHandler(this.SoundLevelCheck_Tick_1);
            // 
            // pnlPlayer
            // 
            this.pnlPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlPlayer.BorderRadius = 30;
            this.pnlPlayer.Controls.Add(this.btnPlayer);
            this.pnlPlayer.Controls.Add(this.lbltitle);
            this.pnlPlayer.Controls.Add(this.lblTimeCounter);
            this.pnlPlayer.Controls.Add(this.lblMAXTime);
            this.pnlPlayer.Controls.Add(this.bar);
            this.pnlPlayer.Controls.Add(this.soundPicture);
            this.pnlPlayer.Controls.Add(this.SoundController);
            this.pnlPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPlayer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlPlayer.Location = new System.Drawing.Point(0, 2);
            this.pnlPlayer.Name = "pnlPlayer";
            this.pnlPlayer.ShadowDecoration.Parent = this.pnlPlayer;
            this.pnlPlayer.Size = new System.Drawing.Size(1410, 45);
            this.pnlPlayer.TabIndex = 5;
            // 
            // btnPlayer
            // 
            this.btnPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnPlayer.FlatAppearance.BorderSize = 0;
            this.btnPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayer.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayer.Image")));
            this.btnPlayer.Location = new System.Drawing.Point(473, -4);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(63, 51);
            this.btnPlayer.TabIndex = 10;
            this.btnPlayer.UseVisualStyleBackColor = false;
            this.btnPlayer.Click += new System.EventHandler(this.btnPlayer_Click_1);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(51, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbltitle.Size = new System.Drawing.Size(193, 25);
            this.lbltitle.TabIndex = 7;
            this.lbltitle.Text = "انقر على مقطع للتشغيل";
            // 
            // lblTimeCounter
            // 
            this.lblTimeCounter.AutoSize = true;
            this.lblTimeCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTimeCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeCounter.ForeColor = System.Drawing.Color.White;
            this.lblTimeCounter.Location = new System.Drawing.Point(542, 6);
            this.lblTimeCounter.Name = "lblTimeCounter";
            this.lblTimeCounter.Size = new System.Drawing.Size(58, 25);
            this.lblTimeCounter.TabIndex = 4;
            this.lblTimeCounter.Text = "0:00";
            // 
            // lblMAXTime
            // 
            this.lblMAXTime.AutoSize = true;
            this.lblMAXTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblMAXTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAXTime.ForeColor = System.Drawing.Color.White;
            this.lblMAXTime.Location = new System.Drawing.Point(1099, 6);
            this.lblMAXTime.Name = "lblMAXTime";
            this.lblMAXTime.Size = new System.Drawing.Size(58, 25);
            this.lblMAXTime.TabIndex = 3;
            this.lblMAXTime.Text = "0:00";
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.bar.HoverState.Parent = this.bar;
            this.bar.Location = new System.Drawing.Point(616, 9);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(477, 22);
            this.bar.TabIndex = 2;
            this.bar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(56)))), ((int)(((byte)(0)))));
            this.bar.Value = 0;
            this.bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.bar_Scroll);
            // 
            // soundPicture
            // 
            this.soundPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.soundPicture.Image = ((System.Drawing.Image)(resources.GetObject("soundPicture.Image")));
            this.soundPicture.Location = new System.Drawing.Point(1186, 0);
            this.soundPicture.Name = "soundPicture";
            this.soundPicture.ShadowDecoration.Parent = this.soundPicture;
            this.soundPicture.Size = new System.Drawing.Size(44, 42);
            this.soundPicture.TabIndex = 1;
            this.soundPicture.TabStop = false;
            this.soundPicture.Click += new System.EventHandler(this.soundPicture_Click);
            // 
            // SoundController
            // 
            this.SoundController.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SoundController.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.SoundController.HoverState.Parent = this.SoundController;
            this.SoundController.Location = new System.Drawing.Point(1236, 9);
            this.SoundController.Name = "SoundController";
            this.SoundController.Size = new System.Drawing.Size(123, 22);
            this.SoundController.TabIndex = 0;
            this.SoundController.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(56)))), ((int)(((byte)(0)))));
            this.SoundController.Value = 100;
            this.SoundController.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SoundController_Scroll_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ctrlPlayPauseMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPlayer);
            this.Name = "ctrlPlayPauseMusic";
            this.Size = new System.Drawing.Size(1410, 47);
            this.pnlPlayer.ResumeLayout(false);
            this.pnlPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soundPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer BarController;
        private System.Windows.Forms.Timer SoundLevelCheck;
        private Guna.UI2.WinForms.Guna2Panel pnlPlayer;
        private System.Windows.Forms.Button btnPlayer;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblTimeCounter;
        private System.Windows.Forms.Label lblMAXTime;
        private Guna.UI2.WinForms.Guna2TrackBar bar;
        private Guna.UI2.WinForms.Guna2PictureBox soundPicture;
        private Guna.UI2.WinForms.Guna2TrackBar SoundController;
        private System.Windows.Forms.Timer timer1;
    }
}
