using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace AmeliyathaneVarYok
{

    
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        //global degiskenler
        public string dbAdres, dbKullAdi, dbSifre, kalanAdi, kalanBasTar;
        int seciliSalon, kalanProtokol;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text += "       Ver. Beta 0.04  24.05.2022";
            AmeliyathaneSecimi();
            BaglantiAyarlari();
            AmeliyatSorgula(seciliSalon);
        }

        private void bağlantıAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAyarlar frmAyar = new FrmAyarlar();
            frmAyar.ShowDialog();
        }
        FrmProtokol frmPro = new FrmProtokol();
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor != Color.SpringGreen)
            {

                frmPro.gelenSalonNo = cbxSalon.SelectedItem.ToString();
                frmPro.dbKullAdi = dbKullAdi;
                frmPro.dbSifre = dbSifre;
                frmPro.dbAdres = dbAdres;

                frmPro.ShowDialog();
                if (frmPro.protokolNo != "" && frmPro.protokolNo != null)
                {
                    btn.BackColor = Color.SpringGreen;
                    btn.Text = cbxSalon.SelectedItem + "\n" + DateTime.Now.ToShortTimeString() + "\nHasta Protokolü\n" + frmPro.protokolNo + "\n" + frmPro.hastaAdi;
                    dgvAmeliyatList.Rows.Add(cbxSalon.SelectedIndex + 1, frmPro.protokolNo, frmPro.hastaAdi, DateTime.Now.ToString("HH:mm:ss"), "", "", DateTime.Now.ToShortDateString());
                    dgvAmeliyatList.CurrentCell = dgvAmeliyatList.Rows[dgvAmeliyatList.RowCount - 1].Cells[0];
                    lblVaka.Text = "Güncel Vaka Sayısı : " + dgvAmeliyatList.RowCount.ToString();
                    AmeliyatInsert(seciliSalon,Convert.ToInt32(frmPro.protokolNo));
                    frmPro.protokolNo = "";
                    tmrSure.Start();
                }
            }
            else
            {
                tmrSure.Stop();
                DialogResult dialogResult = MessageBox.Show("Ameliyat sonlandırılsın mı ?", "Ameliyat Bitti!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    AmeliyatBitir(seciliSalon.ToString());
                    btn.BackColor = default;
                    btn.Text = cbxSalon.SelectedItem.ToString();

                }
                else if (dialogResult == DialogResult.No)
                {
                    tmrSure.Start();
                }
            }
        }

        void AmeliyathaneSecimi()
        {
            cbxSalon.SelectedIndex = Properties.Settings.Default.salonNo -1;
            btnStart.Font = new Font(btnStart.Font.FontFamily, 13);
            btnStart.Text = "Ameliyat Başlat\n" + cbxSalon.SelectedItem.ToString();
            seciliSalon = Properties.Settings.Default.salonNo;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSure_Click(object sender, EventArgs e)
        {
            
        }

        int saat = 0, dakika = 0, saniye = 0;

        private void ameliyathaneRaporlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmRaporlar frmRap = new FrmRaporlar();
            frmRap.dbAdres = dbAdres;
            frmRap.dbSifre = dbSifre;
            frmRap.dbKullAdi = dbKullAdi;
            frmRap.ShowDialog();
        }

        private void bağlantıAyarlarıToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBaglantiAyarlari FrmConnSet = new FrmBaglantiAyarlari();
            FrmConnSet.ShowDialog();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Program kapatılacak, emin misiniz ?", "Program Kapanıyor!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
               
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void tmrSure_Tick(object sender, EventArgs e)
        {
            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
            }
            if (dakika == 60)
            {
                dakika = 0;
                saniye = 0;
                saat++;
            }
            lblSure.Text = String.Format("{0:D2}", saat) + ":" + String.Format("{0:D2}", dakika) + ":" + String.Format("{0:D2}", saniye);
            saniye++;
        }

        void AmeliyatBitir(string salonNo)
        {

            foreach (DataGridViewRow row in dgvAmeliyatList.Rows)
            {
                if (row.Cells[0].Value.ToString() == salonNo && row.Cells[4].Value.ToString() == "")
                {
                    row.Cells[4].Value = DateTime.Now.ToString("HH:mm:ss");
                    row.Cells[7].Value = DateTime.Now.ToShortDateString();
                    string baslangicSaat = row.Cells[3].Value.ToString();
                    string bitisSaat = row.Cells[4].Value.ToString();
                    TimeSpan fark = DateTime.Parse(bitisSaat).Subtract(DateTime.Parse(baslangicSaat));
                    row.Cells[5].Value = fark.ToString();
                    AmeliyatUpdate(seciliSalon, fark.ToString());
                    lblSure.Text = "00:00:00";
                }
            }
        }
        void AmeliyatInsert(int salonNo, int protokolNo)
        {
            string connstr = "data source=" + dbAdres + ";user id=" + dbKullAdi + ";password=" + dbSifre + ";";

            string cmdtxt =
                @"INSERT INTO HASTANE.TBL_AML_OTMM (ID, SALON_NO, PROTOKOL_NO, BASLANGIC_TARIHI) VALUES
                (AML_VARYOK_ID.nextVal,:SALON_NO,:PROTOKOL_NO,:BASTAR)";
            try
            {
                OracleDataAdapter da = new OracleDataAdapter();
                using (OracleConnection conn = new OracleConnection(connstr))
                using (OracleCommand cmd = new OracleCommand(cmdtxt, conn))
                {
                    conn.Open();

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = cmdtxt;
                    cmd.Parameters.Add(":SALON_NO", salonNo);
                    cmd.Parameters.Add(":PROTOKOL_NO", protokolNo);
                    cmd.Parameters.Add(":BASLANGIC_TARIHI", DateTime.Now);

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert Hatası : " + ex.Message);
            }

        }
        void AmeliyatUpdate(int salonNo, string sure)
        {
            string connstr = "data source=" + dbAdres + ";user id=" + dbKullAdi + ";password=" + dbSifre + ";";

            string cmdtxt =
                @"UPDATE HASTANE.TBL_AML_OTMM SET BITIS_TARIHI = :BITTAR, UPDATE_DATE = :UPDATE_DATE, SURE = :SURE
                  WHERE SALON_NO = " + salonNo + " AND BITIS_TARIHI IS NULL";
            try
            {
                OracleDataAdapter da = new OracleDataAdapter();
                using (OracleConnection conn = new OracleConnection(connstr))
                using (OracleCommand cmd = new OracleCommand(cmdtxt, conn))
                {
                    conn.Open();

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = cmdtxt;
                    cmd.Parameters.Add(":BITTAR", DateTime.Now);
                    cmd.Parameters.Add(":UPDATE_DATE", DateTime.Now);
                    cmd.Parameters.Add(":SURE", sure);


                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Hatası : " + ex.Message);
            }

        }

        public void BaglantiAyarlari() // bağlantı ayarları

        {
            string dosya_dizini = AppDomain.CurrentDomain.BaseDirectory.ToString() + "AmeliyathaneVarYok.ini";
            if (File.Exists(dosya_dizini) == false) // dizindeki dosya var mı ?
            {
                const string sPath = "AmeliyathaneVarYok.ini";
                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
                SaveFile.Write("DB=" + "172.0.0.1:1521/orcl" + ";");
                SaveFile.Write("KullAdi=" + "HASTANE" + ";");
                SaveFile.Write("KullSifre=" + "HASTANE");
                SaveFile.Close();

                MessageBox.Show("Bağlantı ayarları bulunamadı. Yeni dosya oluşturuluyor.");

            }
            else
            {

                string veri = "";
                using (StreamReader sr = new StreamReader("AmeliyathaneVarYok.ini"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        veri = line;
                    }
                    sr.Close();
                }

                dbAdres = veri.Substring(3, veri.IndexOf(";") - 3);
                dbSifre = veri.Substring(veri.IndexOf("KullSifre") + 10, veri.Length - (veri.IndexOf("KullSifre") + 10));
                dbKullAdi = veri.Substring(veri.IndexOf("KullAdi=") + 8, (veri.LastIndexOf(";")) - (veri.IndexOf("KullAdi=") + 8));

            }
        }
        public void AmeliyatSorgula(int salonNo)
        {
            string connstr = "data source=" + dbAdres + ";user id=" + dbKullAdi + ";password=" + dbSifre + ";";
            string cmdtxt =
                  @"SELECT distinct AML.BASLANGIC_TARIHI,AML.PROTOKOL_NO, UPPER(KL.ADI) || UPPER(KL.SOYADI) ADI FROM HASTANE.TBL_AML_OTMM AML, HASTANE.PROTOKOL PR, HASTANE.KIMLIK KL
                    WHERE AML.PROTOKOL_NO = PR.PROTOKOL_NO AND PR.DOSYA_NO = KL.DOSYA_NO AND
                    AML.BITIS_TARIHI IS NULL AND AML.SALON_NO = " + salonNo;
            try
            {
                using (OracleConnection conn = new OracleConnection(connstr))
                using (OracleCommand cmd = new OracleCommand(cmdtxt, conn))
                {
                    conn.Open();

                    // reader is IDisposable and should be closed
                    using (OracleDataReader dr = cmd.ExecuteReader())
                    {
                        //List<String> items = new List<String>();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                //items.Add(String.Format("{0}", dr.GetValue(0)));
                                kalanBasTar = Convert.ToDateTime(dr[0]).ToString("T");
                                kalanProtokol = Convert.ToInt32(dr[1]);
                                kalanAdi = dr[2].ToString();

                                btnStart.BackColor = Color.SpringGreen;
                                btnStart.Text = cbxSalon.SelectedItem + "\n"+ kalanAdi + "\n" + kalanBasTar + "\nHasta Protokolü\n" + kalanProtokol;
                                dgvAmeliyatList.Rows.Add(salonNo, kalanProtokol,kalanAdi, kalanBasTar, "", "", DateTime.Now.ToShortDateString());
                                dgvAmeliyatList.CurrentCell = dgvAmeliyatList.Rows[dgvAmeliyatList.RowCount - 1].Cells[0];
                                lblVaka.Text = "Güncel Vaka Sayısı : " + dgvAmeliyatList.RowCount.ToString();
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

    }
}
