namespace AmeliyathaneVarYok
{
    partial class FrmAyarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAyarlar));
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSalon = new System.Windows.Forms.ComboBox();
            this.txtKullAd = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtDbAdres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ameliyathane Seçimi";
            // 
            // cbxSalon
            // 
            this.cbxSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbxSalon.Location = new System.Drawing.Point(38, 132);
            this.cbxSalon.Name = "cbxSalon";
            this.cbxSalon.Size = new System.Drawing.Size(152, 32);
            this.cbxSalon.TabIndex = 17;
            this.cbxSalon.SelectedIndexChanged += new System.EventHandler(this.cbxSalon_SelectedIndexChanged);
            // 
            // txtKullAd
            // 
            this.txtKullAd.Location = new System.Drawing.Point(83, 12);
            this.txtKullAd.Name = "txtKullAd";
            this.txtKullAd.Size = new System.Drawing.Size(100, 20);
            this.txtKullAd.TabIndex = 19;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(83, 38);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '*';
            this.txtPW.Size = new System.Drawing.Size(100, 20);
            this.txtPW.TabIndex = 20;
            // 
            // txtDbAdres
            // 
            this.txtDbAdres.Location = new System.Drawing.Point(83, 64);
            this.txtDbAdres.Name = "txtDbAdres";
            this.txtDbAdres.Size = new System.Drawing.Size(100, 20);
            this.txtDbAdres.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Kull. Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "DB Adresi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Umut BARDAK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "537 700 5383";
            // 
            // FrmAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 230);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDbAdres);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtKullAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxSalon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAyarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAyarlar_FormClosing);
            this.Load += new System.EventHandler(this.FrmAyarlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSalon;
        private System.Windows.Forms.TextBox txtKullAd;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtDbAdres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}