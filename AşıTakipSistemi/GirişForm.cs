using AşıTakipSistemi.Model.Context;
using AşıTakipSistemi.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AşıTakipSistemi
{
    public partial class GirişForm : Form
    {
  
        public GirişForm()
        {
            
            InitializeComponent();
        }

     
        static string conString = "Server=.;Database=AşıTakipVeriTabanı;Trusted_Connection=true;";
        SqlConnection baglanti = new SqlConnection(conString);
        private void girisButon_Click(object sender, EventArgs e)
        {
            try
            {

                     baglanti.Open();

                    if (kullanıcıTip.SelectedItem.Equals("Ebeveyn"))

                    {
                        string sql = "Select * From cocukTables where cocukTables.TC=@tcsi and cocukTables.Şifre=@sifresi";

                        SqlParameter parametre1 = new SqlParameter("@tcsi", tcBox.Text.Trim());
                        SqlParameter parametre2 = new SqlParameter("@sifresi", sifreBox.Text.Trim());
                        SqlCommand komut = new SqlCommand(sql, baglanti);
                        komut.Parameters.Add(parametre1);
                        komut.Parameters.Add(parametre2);
                        DataTable table = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(komut);
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            EbeveynForm ebeveyn = new EbeveynForm();
                            ebeveyn.Show();
                            this.Hide();
                        }
                    }

                    else if (kullanıcıTip.SelectedItem.Equals("Doktor"))
                    {
                        string sqlD = "Select * From doktorTables where doktorTables.TC=@tcsi and doktorTables.Şifre=@sifresi";

                        SqlParameter parametreD = new SqlParameter("@tcsi", tcBox.Text.Trim());
                        SqlParameter parametreD2 = new SqlParameter("@sifresi", sifreBox.Text.Trim());
                        SqlCommand komutD = new SqlCommand(sqlD, baglanti);
                        komutD.Parameters.Add(parametreD);
                        komutD.Parameters.Add(parametreD2);
                        DataTable tableD = new DataTable();
                        SqlDataAdapter adapterD = new SqlDataAdapter(komutD);
                        adapterD.Fill(tableD);
                        if (tableD.Rows.Count > 0)
                        {
                            DoktorForm doktor = new DoktorForm();
                            doktor.Show();
                            this.Hide();

                        }
                    }
                    else if (kullanıcıTip.SelectedItem.Equals("Sekreter"))
                    {
                        string sqlS = "Select * From sekreterTables where sekreterTables.TC=@tcsi and sekreterTables.Şifre=@sifresi";

                        SqlParameter parametreS = new SqlParameter("@tcsi", tcBox.Text.Trim());
                        SqlParameter parametreS2 = new SqlParameter("@sifresi", sifreBox.Text.Trim());
                        SqlCommand komutS = new SqlCommand(sqlS, baglanti);
                        komutS.Parameters.Add(parametreS);
                        komutS.Parameters.Add(parametreS2);
                        DataTable tableS = new DataTable();
                        SqlDataAdapter adapterS = new SqlDataAdapter(komutS);
                        adapterS.Fill(tableS);
                        if (tableS.Rows.Count > 0)
                        {
                            SekreterForm sekreter = new SekreterForm();
                            sekreter.Show();
                            this.Hide();
                        }


                    }

               
            }
            catch (Exception)
            {

                MessageBox.Show("Eksik veya hatalı veri girişi,lütfen tekrar deneyin!");
                baglanti.Close();
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            CreateDbObjects();
        }

        private static void CreateDbObjects()
        {
            AsiTakipDbContext asiVeri = new AsiTakipDbContext();
            asiVeri.Database.CreateIfNotExists();
        }

        public static string tc;

     

        private void tcBox_TextChanged(object sender, EventArgs e)
        {
            tc = tcBox.Text.Trim();
        }

        private void tcBox_Click(object sender, EventArgs e)
        {
            tcBox.Text = " ";
        }

        private void sifreBox_Click(object sender, EventArgs e)
        {
            sifreBox.Text = " ";

        }

        private void kullanıcıTip_Click(object sender, EventArgs e)
        {
            kullanıcıTip.Text = " ";
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            sifreBox.PasswordChar = '*';
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            sifreBox.PasswordChar = '\0';
        }

        private void GirişForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    }
