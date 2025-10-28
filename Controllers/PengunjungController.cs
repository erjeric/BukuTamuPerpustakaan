using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PengunjungController : Controller // 🟢 harus mewarisi Controller
    {
        static List<Pengunjung> data = new List<Pengunjung>();

        public ActionResult Index()
        {
            return View(data);
        }

        [HttpPost]
        public JsonResult Tambah(string nama, string kategori)
        {
            if (!string.IsNullOrWhiteSpace(nama) && !string.IsNullOrWhiteSpace(kategori))
            {
                var item = new Pengunjung
                {
                    ID = Guid.NewGuid().ToString(),
                    Nama = nama,
                    Kategori = kategori,
                    TanggalKunjungan = DateTime.Now
                };
                data.Add(item);
                return Json(new { success = true, pengunjung = item });
            }
            return Json(new { success = false });
        }
    }
}
