using Oracle.ManagedDataAccess.Client;
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

namespace AmeliyathaneVarYok
{
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }
        public string dbAdres, dbKullAdi, dbSifre, baglanti;
        int mevcutSalon;

        private void FrmAyarlar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mevcutSalon != cbxSalon.SelectedIndex + 1)
            {
                Application.Exit();
                MessageBox.Show("Salon numarası değiştirildi. Ayarların geçerli olması için programı yeniden başlatın.", "Program Kapanıyor!");
            }
        }

        private void cbxSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mevcutSalon != cbxSalon.SelectedIndex +1)
            {
                DialogResult dialogResult = MessageBox.Show("Salon numarasını değiştirmek istiyor musunuz ?", "Salon Değişikliği!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Properties.Settings.Default.salonNo = cbxSalon.SelectedIndex + 1;
                    Properties.Settings.Default.Save();
                }
                else if (dialogResult == DialogResult.No)
                {
                    cbxSalon.SelectedIndex = mevcutSalon -1;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            mevcutSalon = Properties.Settings.Default.salonNo;
            cbxSalon.SelectedIndex = Properties.Settings.Default.salonNo - 1;
            BaglantiAyarlari();
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
            string connstr = "data source=" + dbAdres + ";user id=" + dbKullAdi + ";password=" + dbSifre + ";";
            string cmdtxt =
                  @"select * from tbl_aml_otm1";
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
                            //MessageBox.Show("Veritabanı bağlantısı var, tablolar oluşturulmuş.","Bağlantı Sağlandı");
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
            }
        }
    }
}
