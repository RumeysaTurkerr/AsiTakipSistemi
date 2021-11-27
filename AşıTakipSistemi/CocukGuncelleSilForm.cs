using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AşıTakipSistemi
{
    public partial class CocukGuncelleSilForm : Form
    {
        public CocukGuncelleSilForm()
        {
            InitializeComponent();
        }

        static string connString="Server=.;Database=AşıTakipVeriTabanı;Trusted_Connection=true;";
        SqlConnection baglanti = new SqlConnection(connString);
        
        public void showData(string data)
        {
            SqlDataAdapter da = new SqlDataAdapter(data,baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }


        private void araCB_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            showData("Select * from cocukTables where TC like '" + tc.Text + "'");
            baglanti.Close();

            int area = dataGridView1.SelectedCells[0].RowIndex;
            string tc2 = dataGridView1.Rows[area].Cells[1].Value.ToString();
            string sifre = dataGridView1.Rows[area].Cells[2].Value.ToString();
            string ad = dataGridView1.Rows[area].Cells[3].Value.ToString();
            string soyad = dataGridView1.Rows[area].Cells[4].Value.ToString();
            string dogumTarih = dataGridView1.Rows[area].Cells[5].Value.ToString();
            double kilo = Convert.ToDouble(dataGridView1.Rows[area].Cells[6].Value);
            double boy = Convert.ToDouble(dataGridView1.Rows[area].Cells[7].Value);
            string cinsiyet = dataGridView1.Rows[area].Cells[8].Value.ToString();
            tcText.Text = tc2;
            adText.Text = ad;
            sifreText.Text = sifre;
            soyadText.Text = soyad;
            dateTimePicker.Value = Convert.ToDateTime(dogumTarih);
            kiloText.Text = kilo.ToString();
            boyText.Text = boy.ToString();
            if (cinsiyet == "Kız")
            {
                butonKız.Checked = true;
            }
            else if (cinsiyet == "Erkek")
            {
                butonErkek.Checked = true;
            }



        }


        private void silButon_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from cocukTables where TC =@Tc", baglanti);
            komut.Parameters.AddWithValue("@Tc", tc.Text);
            komut.ExecuteNonQuery();
            showData("Select TC,Şifre,Ad,Soyad,DoğumTarihi,Kilo,Boy from cocukTables");
            baglanti.Close();
        }

      

        private void güncelleButon_Click(object sender, EventArgs e)
        {
            string yCinsiyet = null;

            if (butonKız.Checked == true)
            {
                yCinsiyet = "Kız";
            }
            else if (butonErkek.Checked == true)
            {
                yCinsiyet = "Erkek";
            }


            baglanti.Open();
            SqlCommand komut = new SqlCommand("update cocukTables set  TC='" +tcText.Text + "',Şifre='"+sifreText.Text+"',Ad='"+adText.Text+"',Soyad='"+soyadText.Text+"',DoğumTarihi='"+dateTimePicker.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'")+ "',Kilo='"+Convert.ToDouble(kiloText.Text) + "',Boy='"+ Convert.ToDouble(boyText.Text) +"',Cinsiyet='"+yCinsiyet+ "'where TC='"+tc.Text+"'",baglanti);
            komut.ExecuteNonQuery();
            showData("select TC,Şifre,Ad,Soyad,DoğumTarihi,Kilo,Boy,Cinsiyet from cocukTables");
            baglanti.Close();

        }

        private void CocukKayıtGuncelleForm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            showData("select TC,Şifre,Ad,Soyad,DoğumTarihi,Kilo,Boy,Cinsiyet from cocukTables");
            baglanti.Close();

        }
    }
    }

