namespace AmeliyathaneVarYok
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnStart = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bağlantıAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ameliyathaneRaporlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ıNFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvAmeliyatList = new System.Windows.Forms.DataGridView();
            this.SALON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROTOKOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HASTA_ADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAS_SAAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BIT_SAAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SURE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAS_TAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BIT_TAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVaka = new System.Windows.Forms.Label();
            this.cbxSalon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.tmrSure = new System.Windows.Forms.Timer(this.components);
            this.bağlantıAyarlarıToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmeliyatList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(7, 41);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 200);
            this.btnStart.TabIndex = 0;
            this.btnStart.Tag = "1";
            this.btnStart.Text = "Salon 1";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem,
            this.ameliyathaneRaporlarıToolStripMenuItem,
            this.ıNFOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bağlantıAyarlarıToolStripMenuItem,
            this.bağlantıAyarlarıToolStripMenuItem1});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.ayarlarToolStripMenuItem.Text = "&Genel";
            // 
            // bağlantıAyarlarıToolStripMenuItem
            // 
            this.bağlantıAyarlarıToolStripMenuItem.Name = "bağlantıAyarlarıToolStripMenuItem";
            this.bağlantıAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bağlantıAyarlarıToolStripMenuItem.Text = "&Salon Ayarlar";
            this.bağlantıAyarlarıToolStripMenuItem.Click += new System.EventHandler(this.bağlantıAyarlarıToolStripMenuItem_Click);
            // 
            // ameliyathaneRaporlarıToolStripMenuItem
            // 
            this.ameliyathaneRaporlarıToolStripMenuItem.Name = "ameliyathaneRaporlarıToolStripMenuItem";
            this.ameliyathaneRaporlarıToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.ameliyathaneRaporlarıToolStripMenuItem.Text = "&Ameliyathane Raporları";
            this.ameliyathaneRaporlarıToolStripMenuItem.Click += new System.EventHandler(this.ameliyathaneRaporlarıToolStripMenuItem_Click);
            // 
            // ıNFOToolStripMenuItem
            // 
            this.ıNFOToolStripMenuItem.Name = "ıNFOToolStripMenuItem";
            this.ıNFOToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.ıNFOToolStripMenuItem.Text = "&Bilgi";
            // 
            // dgvAmeliyatList
            // 
            this.dgvAmeliyatList.AllowUserToAddRows = false;
            this.dgvAmeliyatList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAmeliyatList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAmeliyatList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmeliyatList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SALON,
            this.PROTOKOL,
            this.HASTA_ADI,
            this.BAS_SAAT,
            this.BIT_SAAT,
            this.SURE,
            this.BAS_TAR,
            this.BIT_TAR});
            this.dgvAmeliyatList.Location = new System.Drawing.Point(213, 41);
            this.dgvAmeliyatList.Name = "dgvAmeliyatList";
            this.dgvAmeliyatList.RowHeadersVisible = false;
            this.dgvAmeliyatList.Size = new System.Drawing.Size(481, 306);
            this.dgvAmeliyatList.TabIndex = 13;
            // 
            // SALON
            // 
            this.SALON.HeaderText = "SALON";
            this.SALON.Name = "SALON";
            this.SALON.Width = 55;
            // 
            // PROTOKOL
            // 
            this.PROTOKOL.HeaderText = "PROTOKOL";
            this.PROTOKOL.Name = "PROTOKOL";
            this.PROTOKOL.Width = 80;
            // 
            // HASTA_ADI
            // 
            this.HASTA_ADI.HeaderText = "HASTA ADI";
            this.HASTA_ADI.Name = "HASTA_ADI";
            this.HASTA_ADI.Width = 150;
            // 
            // BAS_SAAT
            // 
            this.BAS_SAAT.HeaderText = "BAŞLANGIÇ SAATİ";
            this.BAS_SAAT.Name = "BAS_SAAT";
            this.BAS_SAAT.Width = 70;
            // 
            // BIT_SAAT
            // 
            this.BIT_SAAT.HeaderText = "BİTİŞ SAATİ";
            this.BIT_SAAT.Name = "BIT_SAAT";
            this.BIT_SAAT.Width = 70;
            // 
            // SURE
            // 
            this.SURE.HeaderText = "SÜRE";
            this.SURE.Name = "SURE";
            this.SURE.Width = 50;
            // 
            // BAS_TAR
            // 
            this.BAS_TAR.HeaderText = "BAŞLANGIÇ TARİHİ";
            this.BAS_TAR.Name = "BAS_TAR";
            this.BAS_TAR.Width = 70;
            // 
            // BIT_TAR
            // 
            this.BIT_TAR.HeaderText = "BİTİŞ TARİHİ";
            this.BIT_TAR.Name = "BIT_TAR";
            this.BIT_TAR.Width = 70;
            // 
            // lblVaka
            // 
            this.lblVaka.AutoSize = true;
            this.lblVaka.Location = new System.Drawing.Point(534, 25);
            this.lblVaka.Name = "lblVaka";
            this.lblVaka.Size = new System.Drawing.Size(108, 13);
            this.lblVaka.TabIndex = 14;
            this.lblVaka.Text = "Güncel Vaka Sayısı : ";
            // 
            // cbxSalon
            // 
            this.cbxSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSalon.Enabled = false;
            this.cbxSalon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxSalon.FormattingEnabled = true;
            this.cbxSalon.Items.AddRange(new object[] {
            "SALON 1",
            "SALON 2",
            "SALON 3",
            "SALON 4",
            "SALON 5",
            "SALON 6",
            "SALON 7",
            "ENDOSKOPI",
            "ANJIO"});
            this.cbxSalon.Location = new System.Drawing.Point(34, 315);
            this.cbxSalon.Name = "cbxSalon";
            this.cbxSalon.Size = new System.Drawing.Size(152, 32);
            this.cbxSalon.TabIndex = 15;
            this.cbxSalon.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ameliyathane Seçimi";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Courier New", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSure.Location = new System.Drawing.Point(2, 244);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(210, 42);
            this.lblSure.TabIndex = 17;
            this.lblSure.Text = "00:00:00";
            this.lblSure.Click += new System.EventHandler(this.lblSure_Click);
            // 
            // tmrSure
            // 
            this.tmrSure.Interval = 1000;
            this.tmrSure.Tick += new System.EventHandler(this.tmrSure_Tick);
            // 
            // bağlantıAyarlarıToolStripMenuItem1
            // 
            this.bağlantıAyarlarıToolStripMenuItem1.Name = "bağlantıAyarlarıToolStripMenuItem1";
            this.bağlantıAyarlarıToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.bağlantıAyarlarıToolStripMenuItem1.Text = "&Bağlantı Ayarları";
            this.bağlantıAyarlarıToolStripMenuItem1.Click += new System.EventHandler(this.bağlantıAyarlarıToolStripMenuItem1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 365);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxSalon);
            this.Controls.Add(this.lblVaka);
            this.Controls.Add(this.dgvAmeliyatList);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblSure);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ameliyat Var / Yok";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmeliyatList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bağlantıAyarlarıToolStripMenuItem;
        public System.Windows.Forms.DataGridView dgvAmeliyatList;
        private System.Windows.Forms.Label lblVaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALON;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROTOKOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn HASTA_ADI;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAS_SAAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIT_SAAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SURE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAS_TAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIT_TAR;
        private System.Windows.Forms.ComboBox cbxSalon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Timer tmrSure;
        private System.Windows.Forms.ToolStripMenuItem ameliyathaneRaporlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ıNFOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bağlantıAyarlarıToolStripMenuItem1;
    }
}

