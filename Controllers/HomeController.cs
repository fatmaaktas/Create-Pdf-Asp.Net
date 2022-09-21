using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pdf.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PDFdonustur(int id)
        {
            site.m_yeni_dosya = db.tbl_yeni_dosya.Where(t => t.yeni_dosya_id == id).FirstOrDefault();

            return View("PDFdonustur", site);
    }
}
}