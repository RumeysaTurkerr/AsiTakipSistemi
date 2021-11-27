namespace AşıTakipSistemi
{
    partial class SekreterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SekreterForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cocukEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çocukGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asiEkleToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.asiEkleToolStrip,
            this.çıkışToolStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(750, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtEkleToolStripMenuItem,
            this.kayıtGüncelleToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(92, 20);
            this.toolStripMenuItem1.Text = "Kayıt İşlemleri";
            // 
            // kayıtEkleToolStripMenuItem
            // 
            this.kayıtEkleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cocukEkleToolStripMenuItem,
            this.doktorEkleToolStripMenuItem,
            this.yöneticiEkleToolStripMenuItem});
            this.kayıtEkleToolStripMenuItem.Name = "kayıtEkleToolStripMenuItem";
            this.kayıtEkleToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.kayıtEkleToolStripMenuItem.Text = "Kayıt Ekle";
            // 
            // cocukEkleToolStripMenuItem
            // 
            this.cocukEkleToolStripMenuItem.Name = "cocukEkleToolStripMenuItem";
            this.cocukEkleToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.cocukEkleToolStripMenuItem.Text = "Çocuk Ekle";
            this.cocukEkleToolStripMenuItem.Click += new System.EventHandler(this.cocukEkleToolStripMenuItem_Click);
            // 
            // doktorEkleToolStripMenuItem
            // 
            this.doktorEkleToolStripMenuItem.Name = "doktorEkleToolStripMenuItem";
            this.doktorEkleToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.doktorEkleToolStripMenuItem.Text = "Doktor Ekle";
            this.doktorEkleToolStripMenuItem.Click += new System.EventHandler(this.doktorEkleToolStripMenuItem_Click);
            // 
            // yöneticiEkleToolStripMenuItem
            // 
            this.yöneticiEkleToolStripMenuItem.Name = "yöneticiEkleToolStripMenuItem";
            this.yöneticiEkleToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.yöneticiEkleToolStripMenuItem.Text = "Sekreter Ekle";
            this.yöneticiEkleToolStripMenuItem.Click += new System.EventHandler(this.yöneticiEkleToolStripMenuItem_Click);
            // 
            // kayıtGüncelleToolStripMenuItem
            // 
            this.kayıtGüncelleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çocukGüncelleToolStripMenuItem,
            this.doktorGüncelleToolStripMenuItem,
            this.yöneticiGüncelleToolStripMenuItem});
            this.kayıtGüncelleToolStripMenuItem.Name = "kayıtGüncelleToolStripMenuItem";
            this.kayıtGüncelleToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.kayıtGüncelleToolStripMenuItem.Text = "Kayıt Güncelle Ve Sil";
            // 
            // çocukGüncelleToolStripMenuItem
            // 
            this.çocukGüncelleToolStripMenuItem.Name = "çocukGüncelleToolStripMenuItem";
            this.çocukGüncelleToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.çocukGüncelleToolStripMenuItem.Text = "Çocuk Güncelle Ve Sil";
            this.çocukGüncelleToolStripMenuItem.Click += new System.EventHandler(this.çocukGüncelleToolStripMenuItem_Click);
            // 
            // doktorGüncelleToolStripMenuItem
            // 
            this.doktorGüncelleToolStripMenuItem.Name = "doktorGüncelleToolStripMenuItem";
            this.doktorGüncelleToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.doktorGüncelleToolStripMenuItem.Text = "Doktor Güncelle Ve Sil";
            this.doktorGüncelleToolStripMenuItem.Click += new System.EventHandler(this.doktorGüncelleToolStripMenuItem_Click);
            // 
            // yöneticiGüncelleToolStripMenuItem
            // 
            this.yöneticiGüncelleToolStripMenuItem.Name = "yöneticiGüncelleToolStripMenuItem";
            this.yöneticiGüncelleToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.yöneticiGüncelleToolStripMenuItem.Text = "Sekreter Güncelle Ve Sil";
            this.yöneticiGüncelleToolStripMenuItem.Click += new System.EventHandler(this.yöneticiGüncelleToolStripMenuItem_Click);
            // 
            // asiEkleToolStrip
            // 
            this.asiEkleToolStrip.AutoSize = false;
            this.asiEkleToolStrip.Name = "asiEkleToolStrip";
            this.asiEkleToolStrip.Size = new System.Drawing.Size(103, 20);
            this.asiEkleToolStrip.Text = "Aşı Takvimi Ekle";
            this.asiEkleToolStrip.Click += new System.EventHandler(this.asiEkleToolStrip_Click);
            // 
            // çıkışToolStrip
            // 
            this.çıkışToolStrip.Name = "çıkışToolStrip";
            this.çıkışToolStrip.Size = new System.Drawing.Size(66, 20);
            this.çıkışToolStrip.Text = "Çıkış Yap";
            this.çıkışToolStrip.Click += new System.EventHandler(this.çıkışToolStrip_Click);
            // 
            // SekreterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 381);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SekreterForm";
            this.Text = "SekreterForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kayıtEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asiEkleToolStrip;
        private System.Windows.Forms.ToolStripMenuItem cocukEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çocukGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStrip;
    }
}