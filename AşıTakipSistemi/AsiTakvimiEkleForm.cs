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
    public partial class AsiTakvimiEkleForm : Form
    {
    
        public AsiTakvimiEkleForm()
        {
            InitializeComponent();
        }
        
        AsiTakipDbContext asiDb = new AsiTakipDbContext();
        private void kaydet4Buton_Click(object sender, EventArgs e)
        {
            try
            {
                asiTable asi = new asiTable();
                asi.TCId = asiTcBox.Text.Trim();
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
                    asi.DaBT_IPA= "Yapıldı";
                if (opaBox.Checked)
                    asi.OPA= "Yapıldı";
                if (sçBox.Checked)
                    asi.SuÇiçeği = "Yapıldı";
                if (sçBox.Checked)
                    asi.SuÇiçeği = "Yapıldı";
                if (dtBox.Checked)
                    asi.DifteriTetanoz = "Yapıldı";
                if (hepaBox.Checked)
                    asi.HepA= "Yapıldı";

                asiDb.AsiTablo.Add(asi);
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
