using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AşıTakipSistemi.Model.Entity
{
    class sekreterTable
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "TC boş bırakılamaz!")]
        [StringLength(11, ErrorMessage = "TC 11 haneli olmalıdır!")]
        public string TC { get; set; }

        [Required(ErrorMessage = "Şifre boş bırakılamaz!")]
        [MinLength(4, ErrorMessage = "Şifre en az 4 karakterden oluşmalıdır!")]
        [MaxLength(8, ErrorMessage = "Şifre en fazla 8 karakterden oluşmalıdır!")]
        public string Şifre { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
