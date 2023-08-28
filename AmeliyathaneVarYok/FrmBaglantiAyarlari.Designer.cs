namespace AmeliyathaneVarYok
{
    partial class FrmBaglantiAyarlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaglantiAyarlari));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDbAdres = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtKullAd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBaglanti = new System.Windows.Forms.Button();
            this.lsBoxSalon = new System.Windows.Forms.ListBox();
            this.txtSalonAdi = new System.Windows.Forms.TextBox();
            this.btnSalonEkle = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seçiliSalonuSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "DB Adresi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Kull. Adı";
            // 
            // txtDbAdres
            // 
            this.txtDbAdres.Location = new System.Drawing.Point(83, 58);
            this.txtDbAdres.Name = "txtDbAdres";
            this.txtDbAdres.Size = new System.Drawing.Size(135, 20);
            this.txtDbAdres.TabIndex = 2;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(83, 32);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '*';
            this.txtPW.Size = new System.Drawing.Size(135, 20);
            this.txtPW.TabIndex = 1;
            // 
            // txtKullAd
            // 
            this.txtKullAd.Location = new System.Drawing.Point(83, 6);
            this.txtKullAd.Name = "txtKullAd";
            this.txtKullAd.Size = new System.Drawing.Size(135, 20);
            this.txtKullAd.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tablo Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "537 700 5383";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Umut BARDAK";
            // 
            // btnBaglanti
            // 
            this.btnBaglanti.Location = new System.Drawing.Point(12, 84);
            this.btnBaglanti.Name = "btnBaglanti";
            this.btnBaglanti.Size = new System.Drawing.Size(100, 25);
            this.btnBaglanti.TabIndex = 3;
            this.btnBaglanti.Text = "Bağlantı Sına";
            this.btnBaglanti.UseVisualStyleBackColor = true;
            this.btnBaglanti.Click += new System.EventHandler(this.btnBaglanti_Click);
            // 
            // lsBoxSalon
            // 
            this.lsBoxSalon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsBoxSalon.ContextMenuStrip = this.contextMenuStrip1;
            this.lsBoxSalon.FormattingEnabled = true;
            this.lsBoxSalon.Location = new System.Drawing.Point(3, 177);
            this.lsBoxSalon.Name = "lsBoxSalon";
            this.lsBoxSalon.Size = new System.Drawing.Size(221, 160);
            this.lsBoxSalon.TabIndex = 33;
            // 
            // txtSalonAdi
            // 
            this.txtSalonAdi.Location = new System.Drawing.Point(1, 148);
            this.txtSalonAdi.Name = "txtSalonAdi";
            this.txtSalonAdi.Size = new System.Drawing.Size(135, 20);
            this.txtSalonAdi.TabIndex = 5;
            // 
            // btnSalonEkle
            // 
            this.btnSalonEkle.Location = new System.Drawing.Point(142, 145);
            this.btnSalonEkle.Name = "btnSalonEkle";
            this.btnSalonEkle.Size = new System.Drawing.Size(82, 25);
            this.btnSalonEkle.TabIndex = 6;
            this.btnSalonEkle.Text = "Salon Ekle";
            this.btnSalonEkle.UseVisualStyleBackColor = true;
            this.btnSalonEkle.Click += new System.EventHandler(this.btnSalonEkle_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçiliSalonuSilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // seçiliSalonuSilToolStripMenuItem
            // 
            this.seçiliSalonuSilToolStripMenuItem.Name = "seçiliSalonuSilToolStripMenuItem";
            this.seçiliSalonuSilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seçiliSalonuSilToolStripMenuItem.Text = "Seçili Salonu Sil";
            this.seçiliSalonuSilToolStripMenuItem.Click += new System.EventHandler(this.seçiliSalonuSilToolStripMenuItem_Click);
            // 
            // frmBaglantiAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 373);
            this.Controls.Add(this.btnSalonEkle);
            this.Controls.Add(this.txtSalonAdi);
            this.Controls.Add(this.lsBoxSalon);
            this.Controls.Add(this.btnBaglanti);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDbAdres);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtKullAd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBaglantiAyarlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oracle DB Ayarları";
            this.Load += new System.EventHandler(this.frmBaglantiAyarlari_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDbAdres;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtKullAd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBaglanti;
        private System.Windows.Forms.ListBox lsBoxSalon;
        private System.Windows.Forms.TextBox txtSalonAdi;
        private System.Windows.Forms.Button btnSalonEkle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seçiliSalonuSilToolStripMenuItem;
    }
}