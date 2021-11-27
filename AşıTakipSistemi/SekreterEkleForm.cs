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
    public partial class SekreterEkleForm : Form
    {
        static AsiTakipDbContext asiTakipDbContext;
        public SekreterEkleForm()
        {
            InitializeComponent();
        }

        AsiTakipDbContext asiDb = new AsiTakipDbContext();
        private void kaydet3Buton_Click(object sender, EventArgs e)
        {
            try
            {
            sekreterTable sekreter= new sekreterTable();
            sekreter.TC = tcBoxId.Text.Trim();
            sekreter.Şifre = sifreBoxC.Text.Trim();
            sekreter.Ad = adBoxC.Text.Trim();
            sekreter.Soyad = soyadBoxC.Text.Trim();

            asiDb.SekreterTablo.Add(sekreter);
            asiDb.SaveChanges();
            MessageBox.Show("Kayıt Başarı İle Eklenmiştir.");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Eklenemedi.Veri girişlerini kontrol edip tekrar deneyin!");
               
            }
        }
    }
}
