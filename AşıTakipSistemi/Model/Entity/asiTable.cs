using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AşıTakipSistemi.Model.Entity
{
    class asiTable
    {
        public int ID { get; set; }

        [Required]
        public string TCId { get; set; }
        public virtual cocukTable cocukTable { get; set; }
        public string HepB { get; set; }
        public string BCG { get; set; }
        public string DaBT_IPA_Hib { get; set; }
        public string KPA { get; set; }
        public string OPA { get; set; }
        public string SuÇiçeği { get; set; }
        public string KKK { get; set; }
        public string HepA { get; set; }
        public string DaBT_IPA { get; set; }
        public string DifteriTetanoz  { get; set; }
      
      


    }
}
