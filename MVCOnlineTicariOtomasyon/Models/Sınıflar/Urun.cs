using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCOnlineTicariOtomasyon.Models.Sınıflar
{
    public class Urun
    {
        [Key]
        public int UrunId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string UrunAd { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Marka { get; set; }

        public short Stok { get; set; }
        public decimal AlisFiyat { get; set; }
        public decimal SatisFiyat { get; set; }
        public bool Durum { get; set; } // ture false olarak ürünün kritk durumunu 

        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string UrunGorsel { get; set; }
        public int Kategoriid { get; set; }
        public virtual Kategori Kategori { get; set; } // her ürünümün bir kategorisi olabilir
        public ICollection<SatisHareket> SatisHarekets { get; set; }
    }
}