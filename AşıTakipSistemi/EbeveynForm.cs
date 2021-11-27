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

   
    public partial class EbeveynForm : Form
    {
        SqlDataReader dr;
        DateTime dogumTarihi;
        DateTime simdikiZaman;
        int gun;
        int ay;
        int yas;
        TimeSpan fark;
        DateTime asiZaman;

        public EbeveynForm()
        {
            InitializeComponent();
        }

        static string conString = "Server=.;Database=AşıTakipVeriTabanı;Trusted_Connection=true;";
        SqlConnection baglanti = new SqlConnection(conString);
       


        public string arama(string aranan)
        {
            baglanti.Open();
            string aramaKomut = "select HepB,BCG,DaBT_IPA_Hib,KPA,OPA,SuÇiçeği,KKK,HepA,DaBT_IPA,DifteriTetanoz  from asiTables where TCId like'" + aranan + "'";
            SqlDataAdapter adaptor = new SqlDataAdapter(aramaKomut, baglanti);
            DataTable tablo = new DataTable();
            adaptor.Fill(tablo);
            dataGridView1.DataSource = tablo;

            string sifre = "select Şifre from cocukTables where TC='" + aranan + "'";
            SqlCommand komut = new SqlCommand(sifre, baglanti);
            adaptor = new SqlDataAdapter(sifre, baglanti);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                sifre = dr["Şifre"].ToString();
            }
            baglanti.Close();

            return sifre;

        }

        public string bilgiDondur(string arananTc)
        {

            baglanti.Open();
            string adSoyad = "select Ad,Soyad,DoğumTarihi from cocukTables where TC like'" + arananTc + "'";
            SqlCommand komut = new SqlCommand(adSoyad, baglanti);
            SqlDataAdapter adaptor = new SqlDataAdapter(adSoyad, baglanti);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                dogumTarihi = Convert.ToDateTime(dr["DoğumTarihi"]);
                adLabel.Text = dr["Ad"].ToString() + " " + dr["Soyad"].ToString();
            }
            simdikiZaman = DateTime.Today;
            gun = simdikiZaman.Day - dogumTarihi.Day;
            ay = simdikiZaman.Month - dogumTarihi.Month;
            yas = simdikiZaman.Year - dogumTarihi.Year;
            if (yas < 1)
            {
                if (ay < 1 || (ay == 1 && gun == 0))
                {
                    asiZaman = dogumTarihi.AddMonths(1);
                }
                else if (ay < 2 || (ay == 2 && gun == 0))
                {
                    asiZaman = dogumTarihi.AddMonths(2);
                }
                else if (ay < 4 || (ay == 4 && gun == 0))
                {
                    asiZaman = dogumTarihi.AddMonths(4);
                }
                else if (ay < 6 || (ay == 6 && gun == 0))
                {
                    asiZaman = dogumTarihi.AddMonths(6);
                }
                else if (ay < 12 )
                {
                    asiZaman = dogumTarihi.AddYears(1);
                }

            }
            else if (yas >= 1 && yas <= 2)
            {
                if (ay < 6 || (ay == 6 && gun == 0))
                {
                    asiZaman = dogumTarihi.AddYears(1);
                    asiZaman = dogumTarihi.AddMonths(6);
                }
                else if (ay < 12 || (yas == 2 && ay == 0))
                {
                    asiZaman = dogumTarihi.AddYears(2);
                }

            }
            else if(yas>2 && yas<=13)
            if (yas < 6 || (yas == 6 && ay == 0))
            {
                asiZaman = dogumTarihi.AddYears(6);
            }
            else if (yas < 13 || (yas == 13 && ay == 0))
            {
                asiZaman = dogumTarihi.AddYears(13);

            }
            
            fark = simdikiZaman - asiZaman;
            tarihLabel.Text = asiZaman.Day.ToString() + "." + asiZaman.Month.ToString() + "." + asiZaman.Year.ToString();
            KalanSüreLabel.Text =Math.Abs(fark.Days).ToString();
            baglanti.Close();


            return Math.Abs(fark.Days).ToString();
        }

        private void EbeveynForm_Load(object sender, EventArgs e)
        {

            arama(GirişForm.tc);
            bilgiDondur(GirişForm.tc);
       

        }
        private void button1_Click(object sender, EventArgs e)
        {
            GirişForm giriş = new GirişForm();
            giriş.Show();
            this.Close();
        }

        private void asiBilgiButon_Click(object sender, EventArgs e)
        {
            AsiBilgiForm asiBilgiGoster = new AsiBilgiForm();
            asiBilgiGoster.Show();
        }

    
    }
}
