namespace QURAAN_PLAYER
{
    partial class ctrlSuratInfo
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
            this.lblIndex = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndex.ForeColor = System.Drawing.Color.White;
            this.lblIndex.Location = new System.Drawing.Point(221, 3);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblIndex.Size = new System.Drawing.Size(25, 28);
            this.lblIndex.TabIndex = 2;
            this.lblIndex.Text = "0";
            this.lblIndex.Click += new System.EventHandler(this.lblIndex_Click_1);
            this.lblIndex.MouseEnter += new System.EventHandler(this.ctrlSuratInfo_MouseEnter);
            this.lblIndex.MouseLeave += new System.EventHandler(this.ctrlSuratInfo_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(148, 3);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(55, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "سورة";
            this.label1.Click += new System.EventHandler(this.lblIndex_Click_1);
            this.label1.MouseEnter += new System.EventHandler(this.ctrlSuratInfo_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.ctrlSuratInfo_MouseLeave);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(49, 3);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblName.Size = new System.Drawing.Size(51, 28);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "النور";
            this.lblName.Click += new System.EventHandler(this.lblIndex_Click_1);
            this.lblName.MouseEnter += new System.EventHandler(this.ctrlSuratInfo_MouseEnter);
            this.lblName.MouseLeave += new System.EventHandler(this.ctrlSuratInfo_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 3);
            this.panel1.TabIndex = 5;
            this.panel1.Click += new System.EventHandler(this.lblIndex_Click_1);
            // 
            // ctrlSuratInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIndex);
            this.Name = "ctrlSuratInfo";
            this.Size = new System.Drawing.Size(255, 35);
            this.Click += new System.EventHandler(this.lblIndex_Click_1);
            this.MouseEnter += new System.EventHandler(this.ctrlSuratInfo_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ctrlSuratInfo_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
    }
}
