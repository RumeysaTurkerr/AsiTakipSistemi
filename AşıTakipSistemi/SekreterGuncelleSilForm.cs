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
    public partial class SekreterGuncelleSilForm : Form
    {
        public SekreterGuncelleSilForm()
        {
            InitializeComponent();
        }
        static string connString = "Server=.;Database=AşıTakipVeriTabanı;Trusted_Connection=true;";
        SqlConnection baglanti = new SqlConnection(connString);

        public void showData(string data)
        {
            SqlDataAdapter da = new SqlDataAdapter(data, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
            private void araButon_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            showData("Select * from sekreterTables where TC like '%" + tc.Text + "%'");
            baglanti.Close();

            int area = dataGridView1.SelectedCells[0].RowIndex;
            string tc2 = dataGridView1.Rows[area].Cells[1].Value.ToString();
            string sifre = dataGridView1.Rows[area].Cells[2].Value.ToString();
            string ad = dataGridView1.Rows[area].Cells[3].Value.ToString();
            string soyad = dataGridView1.Rows[area].Cells[4].Value.ToString();

            tcText.Text = tc2;
            adText.Text = ad;
            sifreText.Text = sifre;
            soyadText.Text = soyad;
        }

        private void silButon_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sekreterTables where TC =@Tc", baglanti);
            komut.Parameters.AddWithValue("@Tc", tc.Text);
            komut.ExecuteNonQuery();
            showData("Select * from sekreterTables");
            baglanti.Close();
        }

        private void güncelleButon_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update sekreterTables set  TC='" + tcText.Text + "',Şifre='" + sifreText.Text + "',Ad='" + adText.Text + "',Soyad='" + soyadText.Text  + "'where TC='" + tc.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            showData("select * from sekreterTables");
            baglanti.Close();


        }

        private void SekreterGuncelleSilForm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            showData("select * from sekreterTables");
            baglanti.Close();
        }
    }
}
