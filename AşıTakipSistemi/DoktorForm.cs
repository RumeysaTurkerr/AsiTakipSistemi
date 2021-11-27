using AşıTakipSistemi.Model.Context;
using AşıTakipSistemi.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AşıTakipSistemi
{
    public partial class DoktorForm : Form
    {
        static AsiTakipDbContext Asilar;
        SqlDataReader dr;
        static string connString = "Server=.;Database=AşıTakipVeriTabanı;Trusted_Connection=true;";
        SqlConnection baglanti = new SqlConnection(connString);
      

        public DoktorForm()
        {
            InitializeComponent();
        }


        public void showData(string data)
        {
            SqlDataAdapter da = new SqlDataAdapter(data, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

        }


        public void arama(string aranan)
        {
            baglanti.Open();
            string aramaKomut = "select TCId,HepB,BCG,DaBT_IPA_Hib,KPA,OPA,SuÇiçeği,KKK,HepA,DaBT_IPA,DifteriTetanoz from asiTables where TCId like'" + aranan + "'";
            SqlDataAdapter adaptor = new SqlDataAdapter(aramaKomut, baglanti);
            DataTable tablo = new DataTable();
            adaptor.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglanti.Close();

          
        }

    
        public void bilgiDondur2(string arananTc)
        {

            baglanti.Open();
            string adSoyad = "select Ad,Soyad from doktorTables where TC like'" + arananTc + "'";
            SqlCommand komut = new SqlCommand(adSoyad, baglanti);
            SqlDataAdapter adaptor = new SqlDataAdapter(adSoyad, baglanti);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
               adLabel2.Text = dr["Ad"].ToString() + " " + dr["Soyad"].ToString();

            }
            baglanti.Close();
        }
        private void DoktorForm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            showData("select TCıd,HepB,BCG,DaBT_IPA_Hib,KPA,OPA,SuÇiçeği,KKK,HepA,DaBT_IPA,DifteriTetanoz from asiTables");
            baglanti.Close();
            bilgiDondur2(GirişForm.tc);

        }

        private void guncelleButon_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            Asilar = new AsiTakipDbContext();
            asiTable asi = new asiTable();


            asi.TCId = tcBox.Text.Trim();

            if (hepbBox.Checked)
                asi.HepB = "Yapıldı";
            if (bcgBox.Checked)
                asi.BCG = "Yapıldı";
            if (dabthBox.Checked)
                asi.DaBT_IPA_Hib = "Yapıldı";
            if (kpaBox.Checked)
                asi.KPA = "Yapıldı";
            if (kkkBox.Checked)
                asi.KKK = "Yapıldı";
            if (dabtBox.Checked)
                asi.DaBT_IPA = "Yapıldı";
            if (opaBox.Checked)
                asi.OPA = "Yapıldı";
            if (sçBox.Checked)
                asi.SuÇiçeği = "Yapıldı";
            if (hepaBox.Checked)
                asi.HepA = "Yapıldı";
            if (dtBox.Checked)
                asi.DifteriTetanoz = "Yapıldı";

            try
            {

                SqlCommand komut = new SqlCommand("update asiTables set  HepB='" + asi.HepB + "',BCG='" + asi.BCG + "',DaBT_IPA_Hib='" + asi.DaBT_IPA_Hib + "',KPA='" + asi.KPA + "',OPA='" + asi.OPA +  "',SuÇiçeği='" + asi.SuÇiçeği + "',KKK='" + asi.KKK + "',HepA='" + asi.HepA + "',DaBT_IPA='" + asi.DaBT_IPA +"',DifteriTetanoz='" + asi.DifteriTetanoz + "'where TCId='" + tcBox.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                showData("select TCId,HepB,BCG,DaBT_IPA_Hib,KPA,OPA,SuÇiçeği,KKK,HepA,DaBT_IPA,DifteriTetanoz from asiTables");
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Eklenemedi.Veri girişlerini kontrol edip tekrar deneyin!");
                throw;
            }
        }
        private void araButon_Click(object sender, EventArgs e)
        {

            arama(tcBox.Text);
            int area = dataGridView2.SelectedCells[0].RowIndex;
            string tc = dataGridView2.Rows[area].Cells[0].Value.ToString();
            string hepB = dataGridView2.Rows[area].Cells[1].Value.ToString();
            string bcg = dataGridView2.Rows[area].Cells[2].Value.ToString();
            string daBT_IPA_Hib = dataGridView2.Rows[area].Cells[3].Value.ToString();
            string kpa = dataGridView2.Rows[area].Cells[4].Value.ToString();
            string opa = dataGridView2.Rows[area].Cells[5].Value.ToString();
            string sç = dataGridView2.Rows[area].Cells[6].Value.ToString();
            string kkk = dataGridView2.Rows[area].Cells[7].Value.ToString();
            string hepA = dataGridView2.Rows[area].Cells[8].Value.ToString();
            string db = dataGridView2.Rows[area].Cells[9].Value.ToString();
            string diftet = dataGridView2.Rows[area].Cells[10].Value.ToString();
            if (hepB == "Yapıldı")
            {
                hepbBox.Checked = true;
            }
            else
            {
                hepbBox.Checked = false;
            }
            if (bcg == "Yapıldı")
            {
                bcgBox.Checked = true;
            }
            else
                bcgBox.Checked = false;

            if (daBT_IPA_Hib == "Yapıldı")
            {
                dabthBox.Checked = true;
            }
            else
                dabthBox.Checked = false;

            if (kpa == "Yapıldı")
            {
                kpaBox.Checked = true;
            }
            else
                kpaBox.Checked = false;

            if (kkk == "Yapıldı")
            {
                kkkBox.Checked = true;
            }
            else
            {
                kkkBox.Checked = false;
            }
            if (db == "Yapıldı")
            {
                dabtBox.Checked = true;

            }
            else
                dabtBox.Checked = false;

            if (opa == "Yapıldı")
            {
                opaBox.Checked = true;
            }
            else
                opaBox.Checked = false;

            if (sç == "Yapıldı")
            {
                sçBox.Checked = true;
            }
            else
                sçBox.Checked = false;


            if (diftet == "Yapıldı")
            {
                dtBox.Checked = true;

            }
            else
                dtBox.Checked = false;

            if (hepA == "Yapıldı")
            {
                hepaBox.Checked = true;

            }
            else
                hepaBox.Checked = false;


        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            baglanti.Open();
            int area = dataGridView2.SelectedCells[0].RowIndex;
            string tc = dataGridView2.Rows[area].Cells[0].Value.ToString();
            string kisiBilgi = "select Ad ,Soyad ,DoğumTarihi ,Kilo ,Boy from cocukTables where TC like'" + tc + "'";
            SqlDataAdapter adaptor = new SqlDataAdapter(kisiBilgi, baglanti);
            DataTable tablo = new DataTable();
            adaptor.Fill(tablo);

            System.Text.StringBuilder b = new System.Text.StringBuilder();
            foreach (System.Data.DataRow r in tablo.Rows)
            {
                foreach (System.Data.DataColumn c in tablo.Columns)
                {
                    b.Append(c.ColumnName.ToString() + "=" + r[c.ColumnName].ToString() + "\n");
                }
            }
            MessageBox.Show(b.ToString(), "Kişi Bilgileri");

            baglanti.Close();


           
        }

      

        private void cıkısButon_Click_1(object sender, EventArgs e)
        {
            GirişForm giris = new GirişForm();
            giris.Show();
            this.Close();
        }

     
    }
}
