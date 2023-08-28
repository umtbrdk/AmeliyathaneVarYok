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
    public partial class FrmBaglantiAyarlari : Form
    {
        public FrmBaglantiAyarlari()
        {
            InitializeComponent();
        }
        public string dbAdres, dbKullAdi, dbSifre, baglanti;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connstr = "data source=" + txtDbAdres.Text + ";user id=" + txtKullAd.Text + ";password=" + txtPW.Text + ";";
                string cmdtxt =
                      @"CREATE TABLE HASTANE.TBL_AML_OTM
                    (
                      BASLANGIC_TARIHI  DATE,
                      BITIS_TARIHI      DATE,
                      SALON_NO          NUMBER,
                      UPDATE_DATE       DATE,
                      ID                NUMBER,
                      CREATEDATE        DATE                        DEFAULT SYSDATE,
                      PROTOKOL_NO       NUMBER,
                      SURE              VARCHAR2(8 BYTE)
                    )";

                using (OracleConnection conn = new OracleConnection(connstr))
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(cmdtxt, conn))
                    {
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        conn.Close();
                    }
                }
                cmdtxt =
                     @"CREATE TABLE HASTANE.AML_SALON_ADI
                       (
                       KODU       NUMBER,
                       SALON_ADI  VARCHAR2(100 BYTE)
                       )";

                using (OracleConnection conn = new OracleConnection(connstr))
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(cmdtxt, conn))
                    {
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        conn.Close();
                    }
                }
                MessageBox.Show("TBL_AML_OTM ve AML_SALON_ADI Tabloları sorunsuz oluşturuldu.","Tablo Oluşturuldu");
                AyarlariKaydet();
            }

            catch (Exception ex)
            {
                string hata = ex.ToString();
                if (hata.Contains("ad var olan"))
                {
                    MessageBox.Show("Tablolar mevcut.", "Bağlantı Sağlandı");
                }
                else MessageBox.Show(ex.ToString());
            }
        }

        private void btnBaglanti_Click(object sender, EventArgs e)
        {
            BaglantiKontrolu();
        }

        private void frmBaglantiAyarlari_Load(object sender, EventArgs e)
        {
            BaglantiAyarlari();
        }

        private void btnSalonEkle_Click(object sender, EventArgs e)
        {
            if(txtSalonAdi.Text.Length > 0)
            {
                lsBoxSalon.Items.Add(txtSalonAdi.Text);
                txtSalonAdi.Text = "";
                txtSalonAdi.Focus();
            }
        }

        private void seçiliSalonuSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lsBoxSalon.Items.Count > 0 && lsBoxSalon.SelectedIndex != -1)
            {
                DialogResult dialogResult = MessageBox.Show(lsBoxSalon.SelectedItem + " - Silinsin mi ?", "Salon Silinecek", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    lsBoxSalon.Items.RemoveAt(lsBoxSalon.SelectedIndex);
            }
            else MessageBox.Show("Silinecek salon seçilmedi.", "Seçim Hatası");
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

                txtDbAdres.Text = dbAdres = veri.Substring(3, veri.IndexOf(";") - 3);
                txtPW.Text = dbSifre = veri.Substring(veri.IndexOf("KullSifre") + 10, veri.Length - (veri.IndexOf("KullSifre") + 10));
                txtKullAd.Text = dbKullAdi = veri.Substring(veri.IndexOf("KullAdi=") + 8, (veri.LastIndexOf(";")) - (veri.IndexOf("KullAdi=") + 8));

            }
        }

        void BaglantiKontrolu()
        {
            string connstr = "data source=" + txtDbAdres.Text + ";user id=" + txtKullAd.Text + ";password=" + txtPW.Text + ";";
            string cmdtxt =
                  @"select * from tbl_aml_otm";
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
                            MessageBox.Show("Program kullanıma hazır. Ameliyathane seçimi yapıp başlayabilirsiniz.", "Bağlantı Sağlandı");
                            AyarlariKaydet();
                        }
                        else
                        {
                            MessageBox.Show("Veritabanı bağlantısı sağlandı, fakat tablolar oluşturulmamış.\nTabloları oluşturmak için aşağıdaki butonu kullanının.", "Bağlantı Sağlandı");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                string hata = ex.ToString();
                if (hata.Contains("tablo veya görüntü"))
                {
                    MessageBox.Show("Veritabanı bağlantısı sağlandı, fakat tablolar bulunamadı.", "Bağlantı Sağlandı");
                }
                else if (hata.Contains("username/pass"))
                {
                    MessageBox.Show("Kullanıcı adı / Şifre hatası", "Bağlantı Sağlandı");
                }
                else if (hata.Contains("Connection request timed"))
                {
                    MessageBox.Show("Veritabanına erişim sağlanamadı. Server IP bilgilerini kontrol edin.", "Bağlantı Hatası");
                }
                else MessageBox.Show("Veritabanına erişim sağlanamadı. Hata Kod : \n" + ex, "Bağlantı Hatası");
            }
        }

        void AyarlariKaydet()
        {
            DialogResult dialogResult = MessageBox.Show("Ayarlar kayıt edilsin mi ?", "Ayarları Kaydet", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    const string sPath = "AmeliyathaneVarYok.ini";

                    System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);

                    SaveFile.Write("DB=" + txtDbAdres.Text + ";");
                    SaveFile.Write("KullAdi=" + txtKullAd.Text + ";");
                    SaveFile.Write("KullSifre=" + txtPW.Text);

                    SaveFile.Close();

                    dbAdres = txtDbAdres.Text;
                    dbKullAdi = txtKullAd.Text;
                    dbSifre = txtPW.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata : " + ex);
                }
            }
        }

    }
}
