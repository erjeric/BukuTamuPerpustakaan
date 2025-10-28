using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Pengunjung
    {
        public string ID { get; set; }
        public string Nama { get; set; }
        public string Kategori { get; set; }
        public DateTime TanggalKunjungan { get; set; }
    }
}