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
    public partial class DoktorEkleForm : Form
    {
        static AsiTakipDbContext asiTakipDbContext;
        public DoktorEkleForm()
        {
            InitializeComponent();
        }

        AsiTakipDbContext asiDb = new AsiTakipDbContext();

        private void kaydet2Buton_Click(object sender, EventArgs e)
        {
            try
            { doktorTable doktor = new doktorTable();
            doktor.TC = tcBoxId.Text.Trim();
            doktor.Şifre = sifreBoxC.Text.Trim();
            doktor.Ad = adBoxC.Text.Trim();
            doktor.Soyad = soyadBoxC.Text.Trim();
            doktor.GörevYeri = gorevYerBox.Text.Trim();
            doktor.TelefonNo = Double.Parse(telNoBox.Text);

            asiDb.DoktorTablo.Add(doktor);
            asiDb.SaveChanges();
            MessageBox.Show("Kayıt Başarı İle Eklenmiştir.");
            }
             catch (Exception)
            {
                MessageBox.Show("Kayıt Eklenemedi.Veri girişlerini kontrol edip,tekrar deneyin!");
                throw;
            }
        }
    }
}
