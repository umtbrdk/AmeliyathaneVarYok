namespace AmeliyathaneVarYok
{
    partial class FrmRaporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRaporlar));
            this.dgvAmeliyatList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.protokolNoDuzeltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAmlytSayisi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpSonTarih = new System.Windows.Forms.DateTimePicker();
            this.dtpIlkTarih = new System.Windows.Forms.DateTimePicker();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.lblSureToplam = new System.Windows.Forms.Label();
            this.cbxSalon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxRaporTipi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmeliyatList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAmeliyatList
            // 
            this.dgvAmeliyatList.AllowUserToAddRows = false;
            this.dgvAmeliyatList.AllowUserToDeleteRows = false;
            this.dgvAmeliyatList.AllowUserToResizeRows = false;
            this.dgvAmeliyatList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAmeliyatList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAmeliyatList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmeliyatList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAmeliyatList.Location = new System.Drawing.Point(2, 77);
            this.dgvAmeliyatList.Name = "dgvAmeliyatList";
            this.dgvAmeliyatList.RowHeadersVisible = false;
            this.dgvAmeliyatList.Size = new System.Drawing.Size(940, 378);
            this.dgvAmeliyatList.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.protokolNoDuzeltToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 26);
            // 
            // protokolNoDuzeltToolStripMenuItem
            // 
            this.protokolNoDuzeltToolStripMenuItem.Name = "protokolNoDuzeltToolStripMenuItem";
            this.protokolNoDuzeltToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.protokolNoDuzeltToolStripMenuItem.Text = "Protokol No Düzelt";
            this.protokolNoDuzeltToolStripMenuItem.Click += new System.EventHandler(this.protokolNoDüzeltToolStripMenuItem_Click);
            // 
            // lblAmlytSayisi
            // 
            this.lblAmlytSayisi.AutoSize = true;
            this.lblAmlytSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmlytSayisi.Location = new System.Drawing.Point(725, 58);
            this.lblAmlytSayisi.Name = "lblAmlytSayisi";
            this.lblAmlytSayisi.Size = new System.Drawing.Size(90, 16);
            this.lblAmlytSayisi.TabIndex = 16;
            this.lblAmlytSayisi.Text = "Ameliyat Adet";
            this.lblAmlytSayisi.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Bitiş Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Başlangıç Tarihi";
            // 
            // dtpSonTarih
            // 
            this.dtpSonTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSonTarih.Location = new System.Drawing.Point(111, 33);
            this.dtpSonTarih.Name = "dtpSonTarih";
            this.dtpSonTarih.Size = new System.Drawing.Size(96, 20);
            this.dtpSonTarih.TabIndex = 18;
            // 
            // dtpIlkTarih
            // 
            this.dtpIlkTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIlkTarih.Location = new System.Drawing.Point(111, 12);
            this.dtpIlkTarih.Name = "dtpIlkTarih";
            this.dtpIlkTarih.Size = new System.Drawing.Size(96, 20);
            this.dtpIlkTarih.TabIndex = 17;
            // 
            // btnRapor
            // 
            this.btnRapor.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRapor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRapor.Image = global::AmeliyathaneVarYok.Properties.Resources.Rapor;
            this.btnRapor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRapor.Location = new System.Drawing.Point(217, 9);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(91, 46);
            this.btnRapor.TabIndex = 21;
            this.btnRapor.Text = "Rapor";
            this.btnRapor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Enabled = false;
            this.btnExcel.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExcel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExcel.Image = global::AmeliyathaneVarYok.Properties.Resources.excel;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(831, 9);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(91, 46);
            this.btnExcel.TabIndex = 22;
            this.btnExcel.Text = "Excel Aktar";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // lblSureToplam
            // 
            this.lblSureToplam.AutoSize = true;
            this.lblSureToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSureToplam.Location = new System.Drawing.Point(-1, 58);
            this.lblSureToplam.Name = "lblSureToplam";
            this.lblSureToplam.Size = new System.Drawing.Size(90, 16);
            this.lblSureToplam.TabIndex = 23;
            this.lblSureToplam.Text = "Ameliyat Süre";
            this.lblSureToplam.Visible = false;
            // 
            // cbxSalon
            // 
            this.cbxSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSalon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxSalon.FormattingEnabled = true;
            this.cbxSalon.Items.AddRange(new object[] {
            "TÜMÜ",
            "SALON 1",
            "SALON 2",
            "SALON 3",
            "SALON 4",
            "SALON 5",
            "SALON 6",
            "SALON 7",
            "ENDOSKOPI",
            "ANJIO"});
            this.cbxSalon.Location = new System.Drawing.Point(464, 27);
            this.cbxSalon.Name = "cbxSalon";
            this.cbxSalon.Size = new System.Drawing.Size(127, 24);
            this.cbxSalon.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Salon Seçimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Rapor Tipi";
            // 
            // cbxRaporTipi
            // 
            this.cbxRaporTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRaporTipi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxRaporTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxRaporTipi.FormattingEnabled = true;
            this.cbxRaporTipi.Items.AddRange(new object[] {
            "Kullanım Süresi",
            "Salon Bazlı Adet",
            "Hekim Bazlı Adet"});
            this.cbxRaporTipi.Location = new System.Drawing.Point(314, 28);
            this.cbxRaporTipi.Name = "cbxRaporTipi";
            this.cbxRaporTipi.Size = new System.Drawing.Size(127, 23);
            this.cbxRaporTipi.TabIndex = 26;
            this.cbxRaporTipi.SelectedIndexChanged += new System.EventHandler(this.cbxRaporTipi_SelectedIndexChanged);
            // 
            // FrmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 467);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxRaporTipi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxSalon);
            this.Controls.Add(this.lblSureToplam);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpSonTarih);
            this.Controls.Add(this.dtpIlkTarih);
            this.Controls.Add(this.lblAmlytSayisi);
            this.Controls.Add(this.dgvAmeliyatList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRaporlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ameliyat Raporları";
            this.Load += new System.EventHandler(this.FrmRaporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmeliyatList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvAmeliyatList;
        private System.Windows.Forms.Label lblAmlytSayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpSonTarih;
        private System.Windows.Forms.DateTimePicker dtpIlkTarih;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label lblSureToplam;
        private System.Windows.Forms.ComboBox cbxSalon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxRaporTipi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem protokolNoDuzeltToolStripMenuItem;
    }
}