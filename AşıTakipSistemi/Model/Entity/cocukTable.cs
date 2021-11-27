using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AşıTakipSistemi.Model.Entity
{
    class cocukTable
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "TC boş bırakılamaz!")]
        [StringLength(11,ErrorMessage ="TC 11 haneli olmalıdır!")]
        public string TC { get; set; }

        [Required(ErrorMessage = "Şifre boş bırakılamaz!")]
        [MinLength(4,ErrorMessage ="Şifre en az 4 karakterden oluşmalıdır!")]
        [MaxLength(8, ErrorMessage = "Şifre en fazla 8 karakterden oluşmalıdır!")]
        public string Şifre { get; set; }
        public string Cinsiyet { get; set; }
        public string Ad{ get; set; }
        public string Soyad { get; set; }

        [Required]
        public DateTime DoğumTarihi { get; set; }

        [Range(0,double.MaxValue,ErrorMessage ="Kilo 0'dan büyük olmalıdır!")]
        public double Kilo { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Boy 0'dan büyük olmalıdır!")]
        public double Boy { get; set; }

        public virtual ICollection<asiTable> AsiTables { get; set; }

        public cocukTable()
        {
            this.AsiTables = new HashSet<asiTable>();
        }
        public cocukTable(int ID,string TC,string Sifre,string Ad,string Soyad,DateTime DoğumTarihi,double Kilo,double Boy )
        {
            this.ID = ID;
            this.TC = TC;
            this.Şifre = Sifre;
            this.Ad =Ad;
            this.Soyad = Soyad;
            this.DoğumTarihi = DoğumTarihi;
            this.Kilo=Kilo;
            this.Boy = Boy;

        }

    }
}
