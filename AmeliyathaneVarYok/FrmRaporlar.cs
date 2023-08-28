using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Oracle.ManagedDataAccess.Client;

namespace AmeliyathaneVarYok
{
    public partial class FrmRaporlar : Form
    {
        public FrmRaporlar()
        {
            InitializeComponent();
        }

        public string dbAdres, dbKullAdi, dbSifre, ilkTarih, sonTarih, salon;

        private void btnRapor_Click(object sender, EventArgs e)
        {
            dgvAmeliyatList.DataSource = null;
            if (cbxSalon.SelectedIndex == 0)
            {
                salon = "";
            }
            else
            {
                salon = " AND AML.SALON_NO = " + (cbxSalon.SelectedIndex);
            }
            RaporSorgulari();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvAmeliyatList.RowCount > 0)
            {

                DialogResult dialogResult = MessageBox.Show("Raporu Excel' e kaydetmek istiyor musun ?", "Kaydet", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ExcellAktar();
                }

            }
            else MessageBox.Show("Kayıt edilecek veri bulunamadı.", "Kayıt Hatası");
        }

        private void cbxRaporTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRaporTipi.SelectedIndex != 0)
            {
                cbxSalon.Enabled = false;
            }
            else cbxSalon.Enabled = true;
        }

        private void protokolNoDüzeltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cbxRaporTipi.SelectedIndex == 0 && dgvAmeliyatList.RowCount > 0)
            {
                int seciliProtokol = Convert.ToInt32(dgvAmeliyatList.CurrentRow.Cells[5].Value.ToString());
                string seciliHasta = dgvAmeliyatList.CurrentRow.Cells[6].Value.ToString();
                int yeniProtokol;

                DialogResult dialogResult = MessageBox.Show(seciliProtokol.ToString() + " Protokol Numaralı\n" + seciliHasta + " hastasını değiştirmek istiyor musunuz ?", "Protokol Düzelt", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    
                    FrmProtokol frmPro = new FrmProtokol();
                    frmPro.dbKullAdi = dbKullAdi;
                    frmPro.dbSifre = dbSifre;
                    frmPro.dbAdres = dbAdres;
                    frmPro.ShowDialog();
                    yeniProtokol = Convert.ToInt32(frmPro.protokolNo);
                    ProtokolDuzelt(seciliProtokol,yeniProtokol);
                    frmPro.protokolNo = "";
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void FrmRaporlar_Load(object sender, EventArgs e)
        {
            cbxSalon.SelectedIndex = 0;
            cbxRaporTipi.SelectedIndex = 0;
        }

        void RaporSorgulari()
        {
            dtpKontrol();
            string sorgu = "";
            if (cbxRaporTipi.SelectedIndex == 0) // Ameliyathane Kullanım Süreleri
            {
                sorgu = @"SELECT   
                AML.SALON_NO,  
                AML.BASLANGIC_TARIHI,
                AML.BITIS_TARIHI,
                trunc((AML.BITIS_TARIHI-AML.BASLANGIC_TARIHI)/1*24*60) AMELIYAT_DK,
                AML.SURE AMELIYAT_SAAT,
                AML.PROTOKOL_NO,
                UPPER(KL.ADI)||' '||UPPER(KL.SOYADI) HASTA_ADI,
                UPPER(DR.ADI_SOYADI) DOKTOR
                    FROM HASTANE.TBL_AML_OTMM AML, HASTANE.PROTOKOL PR, HASTANE.KIMLIK KL, DRADI DR
                WHERE                        
                    AML.PROTOKOL_NO = PR.PROTOKOL_NO
                AND PR.DOSYA_NO = KL.DOSYA_NO
                AND PR.DR_KODU = DR.DR_KODU " + salon +
               @"AND AML.BITIS_TARIHI IS NOT NULL
                AND AML.BASLANGIC_TARIHI BETWEEN " +
                " TO_DATE('" + ilkTarih + " 00:00:00', 'dd.mm.yyyy HH24:MI:SS') and " +
                " TO_DATE('" + sonTarih + " 23:59:59', 'dd.mm.yyyy HH24:MI:SS') " +
               @" GROUP BY AML.BASLANGIC_TARIHI,AML.BITIS_TARIHI,AML.SALON_NO,trunc((AML.BITIS_TARIHI-AML.BASLANGIC_TARIHI)/1*24*60),
                AML.SURE,AML.PROTOKOL_NO,UPPER(KL.ADI)||' '||UPPER(KL.SOYADI),UPPER(DR.ADI_SOYADI)
                ORDER BY AML.BASLANGIC_TARIHI DESC";
            }
            if (cbxRaporTipi.SelectedIndex == 1) // Salon Bazlı Rapor
            {
                sorgu = @"SELECT AML.SALON_NO, COUNT(*) TOPLAM_ADET, SUM(trunc((AML.BITIS_TARIHI-AML.BASLANGIC_TARIHI)/1*24*60)) TOPLAM_DK FROM HASTANE.TBL_AML_OTMM AML
                WHERE AML.BITIS_TARIHI IS NOT NULL AND AML.BASLANGIC_TARIHI BETWEEN" +
                " TO_DATE('" + ilkTarih + " 00:00:00', 'dd.mm.yyyy HH24:MI:SS') and " +
                " TO_DATE('" + sonTarih + " 23:59:59', 'dd.mm.yyyy HH24:MI:SS') " +
                "GROUP BY AML.SALON_NO ORDER BY TOPLAM_DK DESC";
            }
            if (cbxRaporTipi.SelectedIndex == 2) // Hekim Bazlı Rapor
            {
                sorgu = @"SELECT   
                (DR.ADI_SOYADI) DOKTOR, COUNT(*) TOPLAM_ADET,
                SUM(trunc((AML.BITIS_TARIHI-AML.BASLANGIC_TARIHI)/1*24*60)) TOPLAM_DK     
                    FROM HASTANE.TBL_AML_OTMM AML, HASTANE.PROTOKOL PR, HASTANE.KIMLIK KL, DRADI DR
                WHERE                        
                    AML.PROTOKOL_NO = PR.PROTOKOL_NO
                AND PR.DOSYA_NO = KL.DOSYA_NO
                AND PR.DR_KODU = DR.DR_KODU " + salon +
               @"AND AML.BITIS_TARIHI IS NOT NULL
                AND AML.BASLANGIC_TARIHI BETWEEN " +
                " TO_DATE('" + ilkTarih + " 00:00:00', 'dd.mm.yyyy HH24:MI:SS') and " +
                " TO_DATE('" + sonTarih + " 23:59:59', 'dd.mm.yyyy HH24:MI:SS') " +
                "GROUP BY DR.ADI_SOYADI ORDER BY TOPLAM_DK DESC";
            }
            RaporGetir(sorgu);
        }

        void RaporGetir(string sorgu)
        {

            string connstr = "data source=" + dbAdres + ";user id=" + dbKullAdi + ";password=" + dbSifre + ";";
            string cmdtxt = sorgu;

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
                            System.Data.DataTable dataTable = new System.Data.DataTable();
                            dataTable.Load(dr);
                            dgvAmeliyatList.DataSource = dataTable;

                            lblAmlytSayisi.Text = "Toplam Ameliyat Sayısı : " + dgvAmeliyatList.RowCount.ToString();
                            lblAmlytSayisi.Visible = true;

                            if (cbxRaporTipi.SelectedIndex == 0)
                            {
                                lblSureToplam.Text = "Toplam Ameliyat Süresi : " + (from DataGridViewRow row in dgvAmeliyatList.Rows
                                                                                    where !String.IsNullOrEmpty(row.Cells[3].FormattedValue.ToString())
                                                                                    select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString() + "' DK";
                            }
                            else
                            {
                                lblSureToplam.Text = "Toplam Ameliyat Süresi : " + (from DataGridViewRow row in dgvAmeliyatList.Rows
                                                                                    where !String.IsNullOrEmpty(row.Cells[2].FormattedValue.ToString())
                                                                                    select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString() + "' DK";
                            }

                            lblSureToplam.Visible = true;

                            dgvAmeliyatList.AutoResizeColumns();
                            dgvAmeliyatList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                            btnExcel.Enabled = true;
                        }
                        else
                        {
                            lblSureToplam.Visible = false;
                            lblAmlytSayisi.Visible = false;
                            btnExcel.Enabled = false;
                            MessageBox.Show("Girilen tarihe ait veri bulunamadı.", "Veri Bulunamadı");

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void ProtokolDuzelt(int seciliProtokol, int yeniProtokol)
        {
            string connstr = "data source=" + dbAdres + ";user id=" + dbKullAdi + ";password=" + dbSifre + ";";

            string cmdtxt =
                @"UPDATE HASTANE.TBL_AML_OTMM set PROTOKOL_NO = :newPorotkol where protokol_no = " + seciliProtokol;
            try
            {
                OracleDataAdapter da = new OracleDataAdapter();
                using (OracleConnection conn = new OracleConnection(connstr))
                using (OracleCommand cmd = new OracleCommand(cmdtxt, conn))
                {
                    conn.Open();

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = cmdtxt;
                    cmd.Parameters.Add(":newPorotkol", yeniProtokol);

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                }
                MessageBox.Show("Değişiklik Yapıldı. Görüntülemek için sayfayı yenileyiniz.","Protokol Değişti!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Hatası : " + ex.Message);
            }
        }

        private void dtpKontrol()
        {
            ilkTarih = dtpIlkTarih.Value.ToShortDateString();
            sonTarih = dtpSonTarih.Value.ToShortDateString();
        }

        private void ExcellAktar()
        {

            try
            {
                string excelName = "AmeliyathaneRaporu" + "_" + DateTime.Now.ToShortDateString();

                SaveFileDialog save = new SaveFileDialog();
                save.OverwritePrompt = false;
                save.Title = "Excel Dosyaları";
                save.DefaultExt = "xlsx";
                save.Filter = "xlsx Dosyaları (*.xlsx)|*.xlsx|Tüm Dosyalar(*.*)|*.*";
                save.FileName = excelName;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    _Application app = new Microsoft.Office.Interop.Excel.Application();
                    _Workbook workbook = app.Workbooks.Add(Type.Missing);
                    _Worksheet worksheet = null;
                    app.Visible = true;
                    Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
                    worksheet = workbook.ActiveSheet;
                    worksheet.Name = "Excel Dışa Aktarım";
                    for (int i = 1; i < dgvAmeliyatList.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dgvAmeliyatList.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dgvAmeliyatList.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvAmeliyatList.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgvAmeliyatList.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    workbook.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    //app.Quit();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Excel' e aktarım sağlanamadı. Bilgisayarınızda Excel yüklü olduğuna emin olun veya\nGüncel versiyon kullanının.", "Aktarım Başarısız.");
            }

        }

    }
}
