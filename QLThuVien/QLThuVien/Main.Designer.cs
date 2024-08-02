namespace QLThuVien
{
    partial class Main
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
            this.menuSGK = new System.Windows.Forms.MenuStrip();
            this.mnSGK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSTk = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSGK.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuSGK
            // 
            this.menuSGK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSGK.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuSGK.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSGK,
            this.mnSTk});
            this.menuSGK.Location = new System.Drawing.Point(0, 0);
            this.menuSGK.Name = "menuSGK";
            this.menuSGK.Size = new System.Drawing.Size(882, 31);
            this.menuSGK.TabIndex = 0;
            this.menuSGK.Text = "menuStrip1";
            // 
            // mnSGK
            // 
            this.mnSGK.Name = "mnSGK";
            this.mnSGK.Size = new System.Drawing.Size(140, 27);
            this.mnSGK.Text = "Sách giáo khoa";
            this.mnSGK.Click += new System.EventHandler(this.mnSGK_Click);
            // 
            // mnSTk
            // 
            this.mnSTk.Name = "mnSTk";
            this.mnSTk.Size = new System.Drawing.Size(147, 27);
            this.mnSTk.Text = "Sách tham khảo";
            this.mnSTk.Click += new System.EventHandler(this.mnSTk_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.menuSGK);
            this.MainMenuStrip = this.menuSGK;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sách";
            this.menuSGK.ResumeLayout(false);
            this.menuSGK.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuSGK;
        private System.Windows.Forms.ToolStripMenuItem mnSGK;
        private System.Windows.Forms.ToolStripMenuItem mnSTk;
    }
}

