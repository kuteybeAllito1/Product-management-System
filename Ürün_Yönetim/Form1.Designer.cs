namespace Ürün_Yönetim
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniBirÜrünEklemekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tedarikçilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniTedarikçiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satınAlmaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniMüşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.satışNoktasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapalarYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envanterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tahminiKarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kutuyuTaşıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.ürünlerToolStripMenuItem,
            this.tedarikçilerToolStripMenuItem,
            this.müşterilerToolStripMenuItem,
            this.hesaplarToolStripMenuItem,
            this.stokeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1148, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girisToolStripMenuItem,
            this.cikisToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.dosyaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(80, 32);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // girisToolStripMenuItem
            // 
            this.girisToolStripMenuItem.Name = "girisToolStripMenuItem";
            this.girisToolStripMenuItem.Size = new System.Drawing.Size(149, 32);
            this.girisToolStripMenuItem.Text = "Giriş";
            this.girisToolStripMenuItem.Click += new System.EventHandler(this.girisToolStripMenuItem_Click);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Enabled = false;
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(149, 32);
            this.cikisToolStripMenuItem.Text = "Çıkış";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(149, 32);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriYönetimiToolStripMenuItem,
            this.yeniBirÜrünEklemekToolStripMenuItem,
            this.ürünYönetimiToolStripMenuItem});
            this.ürünlerToolStripMenuItem.Enabled = false;
            this.ürünlerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(94, 32);
            this.ürünlerToolStripMenuItem.Text = "Ürünler";
            // 
            // kategoriYönetimiToolStripMenuItem
            // 
            this.kategoriYönetimiToolStripMenuItem.Name = "kategoriYönetimiToolStripMenuItem";
            this.kategoriYönetimiToolStripMenuItem.Size = new System.Drawing.Size(299, 32);
            this.kategoriYönetimiToolStripMenuItem.Text = "Kategoriler yönetimi";
            this.kategoriYönetimiToolStripMenuItem.Click += new System.EventHandler(this.kategoriYönetimiToolStripMenuItem_Click);
            // 
            // yeniBirÜrünEklemekToolStripMenuItem
            // 
            this.yeniBirÜrünEklemekToolStripMenuItem.Name = "yeniBirÜrünEklemekToolStripMenuItem";
            this.yeniBirÜrünEklemekToolStripMenuItem.Size = new System.Drawing.Size(299, 32);
            this.yeniBirÜrünEklemekToolStripMenuItem.Text = "Yeni bir ürün eklemek";
            this.yeniBirÜrünEklemekToolStripMenuItem.Click += new System.EventHandler(this.yeniBirÜrünEklemekToolStripMenuItem_Click);
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            this.ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            this.ürünYönetimiToolStripMenuItem.Size = new System.Drawing.Size(299, 32);
            this.ürünYönetimiToolStripMenuItem.Text = "Ürünler Yönetimi";
            this.ürünYönetimiToolStripMenuItem.Click += new System.EventHandler(this.ürünYönetimiToolStripMenuItem_Click);
            // 
            // tedarikçilerToolStripMenuItem
            // 
            this.tedarikçilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniTedarikçiEkleToolStripMenuItem,
            this.satınAlmaEkleToolStripMenuItem});
            this.tedarikçilerToolStripMenuItem.Enabled = false;
            this.tedarikçilerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tedarikçilerToolStripMenuItem.Name = "tedarikçilerToolStripMenuItem";
            this.tedarikçilerToolStripMenuItem.Size = new System.Drawing.Size(128, 32);
            this.tedarikçilerToolStripMenuItem.Text = "Tedarikçiler";
            // 
            // yeniTedarikçiEkleToolStripMenuItem
            // 
            this.yeniTedarikçiEkleToolStripMenuItem.Name = "yeniTedarikçiEkleToolStripMenuItem";
            this.yeniTedarikçiEkleToolStripMenuItem.Size = new System.Drawing.Size(263, 32);
            this.yeniTedarikçiEkleToolStripMenuItem.Text = "Yeni tedarikçi ekle";
            // 
            // satınAlmaEkleToolStripMenuItem
            // 
            this.satınAlmaEkleToolStripMenuItem.Name = "satınAlmaEkleToolStripMenuItem";
            this.satınAlmaEkleToolStripMenuItem.Size = new System.Drawing.Size(263, 32);
            this.satınAlmaEkleToolStripMenuItem.Text = "Satın alma ekle";
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriYönetimiToolStripMenuItem,
            this.yeniMüşteriEkleToolStripMenuItem,
            this.toolStripSeparator1,
            this.satışNoktasıToolStripMenuItem});
            this.müşterilerToolStripMenuItem.Enabled = false;
            this.müşterilerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(118, 32);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // müşteriYönetimiToolStripMenuItem
            // 
            this.müşteriYönetimiToolStripMenuItem.Name = "müşteriYönetimiToolStripMenuItem";
            this.müşteriYönetimiToolStripMenuItem.Size = new System.Drawing.Size(255, 32);
            this.müşteriYönetimiToolStripMenuItem.Text = "Müşteri yönetimi";
            this.müşteriYönetimiToolStripMenuItem.Click += new System.EventHandler(this.müşteriYönetimiToolStripMenuItem_Click);
            // 
            // yeniMüşteriEkleToolStripMenuItem
            // 
            this.yeniMüşteriEkleToolStripMenuItem.Name = "yeniMüşteriEkleToolStripMenuItem";
            this.yeniMüşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(255, 32);
            this.yeniMüşteriEkleToolStripMenuItem.Text = "Yeni müşteri ekle";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(252, 6);
            // 
            // satışNoktasıToolStripMenuItem
            // 
            this.satışNoktasıToolStripMenuItem.Name = "satışNoktasıToolStripMenuItem";
            this.satışNoktasıToolStripMenuItem.Size = new System.Drawing.Size(255, 32);
            this.satışNoktasıToolStripMenuItem.Text = "Satış noktası";
            // 
            // hesaplarToolStripMenuItem
            // 
            this.hesaplarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapalarYönetimiToolStripMenuItem});
            this.hesaplarToolStripMenuItem.Enabled = false;
            this.hesaplarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hesaplarToolStripMenuItem.Name = "hesaplarToolStripMenuItem";
            this.hesaplarToolStripMenuItem.Size = new System.Drawing.Size(102, 32);
            this.hesaplarToolStripMenuItem.Text = "Hesaplar";
            // 
            // hesapalarYönetimiToolStripMenuItem
            // 
            this.hesapalarYönetimiToolStripMenuItem.Name = "hesapalarYönetimiToolStripMenuItem";
            this.hesapalarYönetimiToolStripMenuItem.Size = new System.Drawing.Size(266, 32);
            this.hesapalarYönetimiToolStripMenuItem.Text = "Hesapalar yönetimi";
            // 
            // stokeToolStripMenuItem
            // 
            this.stokeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.envanterToolStripMenuItem,
            this.tahminiKarToolStripMenuItem,
            this.kutuyuTaşıToolStripMenuItem});
            this.stokeToolStripMenuItem.Enabled = false;
            this.stokeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stokeToolStripMenuItem.Name = "stokeToolStripMenuItem";
            this.stokeToolStripMenuItem.Size = new System.Drawing.Size(74, 32);
            this.stokeToolStripMenuItem.Text = "Depo";
            // 
            // envanterToolStripMenuItem
            // 
            this.envanterToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.envanterToolStripMenuItem.Name = "envanterToolStripMenuItem";
            this.envanterToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.envanterToolStripMenuItem.Text = "Envanter";
            this.envanterToolStripMenuItem.Click += new System.EventHandler(this.envanterToolStripMenuItem_Click);
            // 
            // tahminiKarToolStripMenuItem
            // 
            this.tahminiKarToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.tahminiKarToolStripMenuItem.Name = "tahminiKarToolStripMenuItem";
            this.tahminiKarToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.tahminiKarToolStripMenuItem.Text = "Tahmini kar";
            this.tahminiKarToolStripMenuItem.Click += new System.EventHandler(this.tahminiKarToolStripMenuItem_Click);
            // 
            // kutuyuTaşıToolStripMenuItem
            // 
            this.kutuyuTaşıToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.kutuyuTaşıToolStripMenuItem.Name = "kutuyuTaşıToolStripMenuItem";
            this.kutuyuTaşıToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.kutuyuTaşıToolStripMenuItem.Text = "Kutuyu taşı";
            this.kutuyuTaşıToolStripMenuItem.Click += new System.EventHandler(this.kutuyuTaşıToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Image = global::Ürün_Yönetim.Properties.Resources.box;
            this.button4.Location = new System.Drawing.Point(59, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(229, 214);
            this.button4.TabIndex = 4;
            this.button4.Text = "Ürün ekleme";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = global::Ürün_Yönetim.Properties.Resources.clipboard;
            this.button3.Location = new System.Drawing.Point(313, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 214);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sipariş";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::Ürün_Yönetim.Properties.Resources._3005767_account_door_enter_login_icon;
            this.button1.Location = new System.Drawing.Point(855, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 214);
            this.button1.TabIndex = 1;
            this.button1.Text = "giriş yapmak";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::Ürün_Yönetim.Properties.Resources.check;
            this.button2.Location = new System.Drawing.Point(591, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 214);
            this.button2.TabIndex = 2;
            this.button2.Text = "Satış noktası";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1148, 685);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniBirÜrünEklemekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniMüşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışNoktasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem yeniTedarikçiEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satınAlmaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envanterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tahminiKarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kutuyuTaşıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapalarYönetimiToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem tedarikçilerToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem stokeToolStripMenuItem;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.ToolStripMenuItem hesaplarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem girisToolStripMenuItem;
    }
}

