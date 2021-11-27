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

namespace AşıTakipSistemi
{
    public partial class CocukEkleForm : Form

    {  
        public CocukEkleForm()
        {
            InitializeComponent();
        }
        AsiTakipDbContext asiDb = new AsiTakipDbContext();
        public void kaydetButon_Click(object sender, EventArgs e)
        {
            try
            {
                cocukTable cocuk = new cocukTable();
                cocuk.TC = tcBoxId.Text.Trim();
                cocuk.Şifre = sifreBoxC.Text.Trim();
                if (radioButonKız.Checked == true)
                {
                    cocuk.Cinsiyet = radioButonKız.Text;
                }
                else if(radioButtonErkek.Checked== true)
                {
                    cocuk.Cinsiyet = radioButtonErkek.Text;
                }

                cocuk.Ad = adBoxC.Text.Trim();
                cocuk.Soyad = soyadBoxC.Text.Trim();
                cocuk.DoğumTarihi = dateC.Value;
                cocuk.Kilo = Double.Parse(kiloBox.Text);
                cocuk.Boy = Double.Parse(boyBox.Text);

                FileHelper.cocukEkle(cocuk);
                asiDb.CocukTablo.Add(cocuk);
                asiDb.SaveChanges();
                MessageBox.Show("Kayıt Başarı İle Eklenmiştir.");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Eklenemedi.Veri girişlerini kontrol edip tekrar deneyin!");
                throw;
            }

        }
        private static List<cocukTable> cocukKayıt = new List<cocukTable>();
        private void CocukEkleForm_Load(object sender, EventArgs e)
        {
            FileHelper.CocukKayıtOlustur();
            FileHelper.IlkCocukKayıtEkle();
            cocukKayıt = FileHelper.cocukKayıtlarıOku();
        }
    }
}
