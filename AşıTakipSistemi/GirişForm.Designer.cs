namespace AşıTakipSistemi
{
    partial class GirişForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirişForm));
            this.tcBox = new System.Windows.Forms.TextBox();
            this.sifreBox = new System.Windows.Forms.TextBox();
            this.girisButon = new System.Windows.Forms.Button();
            this.kullanıcıTip = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcBox
            // 
            this.tcBox.BackColor = System.Drawing.Color.White;
            this.tcBox.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcBox.ForeColor = System.Drawing.Color.DarkMagenta;
            this.tcBox.Location = new System.Drawing.Point(367, 83);
            this.tcBox.Name = "tcBox";
            this.tcBox.Size = new System.Drawing.Size(288, 23);
            this.tcBox.TabIndex = 1;
            this.tcBox.Text = "TC Kimlik No ";
            this.tcBox.Click += new System.EventHandler(this.tcBox_Click);
            this.tcBox.TextChanged += new System.EventHandler(this.tcBox_TextChanged);
            // 
            // sifreBox
            // 
            this.sifreBox.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreBox.ForeColor = System.Drawing.Color.DarkMagenta;
            this.sifreBox.Location = new System.Drawing.Point(367, 143);
            this.sifreBox.Name = "sifreBox";
            this.sifreBox.Size = new System.Drawing.Size(288, 23);
            this.sifreBox.TabIndex = 3;
            this.sifreBox.Text = "Şifre ";
            this.sifreBox.Click += new System.EventHandler(this.sifreBox_Click);
            // 
            // girisButon
            // 
            this.girisButon.BackColor = System.Drawing.Color.DarkMagenta;
            this.girisButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisButon.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisButon.ForeColor = System.Drawing.Color.White;
            this.girisButon.Location = new System.Drawing.Point(366, 265);
            this.girisButon.Name = "girisButon";
            this.girisButon.Size = new System.Drawing.Size(289, 41);
            this.girisButon.TabIndex = 8;
            this.girisButon.Text = "GİRİŞ YAP";
            this.girisButon.UseVisualStyleBackColor = false;
            this.girisButon.Click += new System.EventHandler(this.girisButon_Click);
            // 
            // kullanıcıTip
            // 
            this.kullanıcıTip.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcıTip.ForeColor = System.Drawing.Color.DarkMagenta;
            this.kullanıcıTip.FormattingEnabled = true;
            this.kullanıcıTip.Items.AddRange(new object[] {
            "Ebeveyn",
            "Doktor",
            "Sekreter"});
            this.kullanıcıTip.Location = new System.Drawing.Point(367, 207);
            this.kullanıcıTip.Name = "kullanıcıTip";
            this.kullanıcıTip.Size = new System.Drawing.Size(288, 24);
            this.kullanıcıTip.TabIndex = 9;
            this.kullanıcıTip.Text = "Kullanıcı Tipleri";
            this.kullanıcıTip.Click += new System.EventHandler(this.kullanıcıTip_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(630, 143);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 23);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.DoubleClick += new System.EventHandler(this.pictureBox3_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(335, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "AŞI TAKİP SİSTEMİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // GirişForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(714, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.kullanıcıTip);
            this.Controls.Add(this.girisButon);
            this.Controls.Add(this.sifreBox);
            this.Controls.Add(this.tcBox);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GirişForm";
            this.Text = "Aşı Takip Sistemi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GirişForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tcBox;
        private System.Windows.Forms.TextBox sifreBox;
        private System.Windows.Forms.Button girisButon;
        private System.Windows.Forms.ComboBox kullanıcıTip;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

