using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace AmeliyathaneVarYok
{
    public partial class FrmProtokol : Form
    {
        public FrmProtokol()
        {
            InitializeComponent();
        }
        public string gelenSalonNo, protokolNo, dosyaNo, hastaAdi;
        public string dbAdres, dbKullAdi, dbSifre;
        //FrmMain mainFrm = new FrmMain();
        private void FrmProtokol_Load(object sender, EventArgs e)
        {
            lblSalon.Text = gelenSalonNo + " için";
            txtProtokolNo.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtProtokolNo.Text += btn.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtProtokolNo.Text.Length > 0)
            {
                string deger = txtProtokolNo.Text;
                txtProtokolNo.Text = deger.Substring(0, deger.Length - 1);
            }
            else txtProtokolNo.Focus();

        }

        private void FrmProtokol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                txtProtokolNo.Text =  protokolNo = "";
            }
        }

        private void txtProtokolNo_TextChanged(object sender, EventArgs e)
        {
            if (txtProtokolNo.Text == "")
            {
                btnKapat.Text = "Kapat";
                btnKapat.BackColor = Color.LightCoral;
            }
            else
            {
                btnKapat.Text = "Tümünü Sil";
                btnKapat.BackColor = default;
            }
        }

        private void txtProtokolNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void lblSalon_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            FrmMain mainFrm = new FrmMain();

            if (txtProtokolNo.Text != "" && txtProtokolNo.Text != null)
            {
                protokolNo = txtProtokolNo.Text;
                ProtokolSorgula(Convert.ToInt32(protokolNo));
                if (txtProtokolNo.Text != "")
                {
                    txtProtokolNo.Text = "";
                    this.Close();
                }
                else txtProtokolNo.Text = "";

            }
            else
            {
                MessageBox.Show("Protokol No alanı boş bırakılamaz.", "Hata");
                txtProtokolNo.Text = "";
            }


        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (btnKapat.Text == "Kapat")
            {
                txtProtokolNo.Text = "";
                protokolNo = "";
                this.Close();
            }
            else
            {
                txtProtokolNo.Text = "";
                protokolNo = "";
                txtProtokolNo.Focus();
            }
            
        }
        public void ProtokolSorgula(int protokol)
        {

            string connstr = "data source=" + dbAdres + ";user id=" + dbKullAdi + ";password=" + dbSifre + ";";
            string cmdtxt =
                  @"select pr.protokol_no, pr.dosya_no, upper(kl.adi) || ' ' || upper(kl.soyadi) as adi from hastane.protokol pr, hastane.kimlik kl
                    where pr.dosya_no = kl.dosya_no and pr.protokol_no =" + protokol;
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
                                dosyaNo = dr[1].ToString();
                                hastaAdi = dr[2].ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Girilen protokol bulunamadı.", "Hatalı Protokol");
                            protokolNo = "";
                            txtProtokolNo.Text = "";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtProtokolNo.Text = "";
            }
        }

    }
}
