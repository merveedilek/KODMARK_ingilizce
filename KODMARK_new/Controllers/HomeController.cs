using KODMARK_new.Data;
using KODMARK_new.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace KODMARK_new.Controllers
{
    public class HomeController : Controller
    {
        private KodmarkData _data;
        // GET: Home
        public HomeController()
        {
            _data = new KodmarkData();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Hakkimizda()
        {
            return View();
        }
        public ActionResult Vision()
        {
            return View();
        }
        public ActionResult BaskiliEtiket()
        {
            return View();
        }
        public ActionResult BaskisizEtiket()
        {
            return View();
        }
        public ActionResult Ribon()
        {
            return View();
        }
        public ActionResult Endustriyel()
        {
            return View();
        }
        public ActionResult Masaustu()
        {
            return View();
        }
        public ActionResult Mobil()
        {
            return View();
        }
        public ActionResult BarcodeYazici()
        {
            return View();
        }
        public ActionResult BarkodOkuyucu()
        {
            return View();
        }
        [HttpPost]
        public ActionResult iletisim(iletisim form)
        {
            SmtpClient mailClient = new SmtpClient("smtp.gmail.com", 587);
            NetworkCredential cred = new NetworkCredential("kodmark2@gmail.com", "Kodmark123");
            mailClient.Credentials = cred;
            MailMessage iletisim = new MailMessage();
            iletisim.From = new MailAddress("kodmark2@gmail.com"); //burası kendi maili
            iletisim.Subject = "İletişim Formu " + DateTime.Now;
            iletisim.IsBodyHtml = true;
            iletisim.Body = "kodmark.com web sitesinden iletişim formu dolduruldu. <br/>";
            iletisim.Body += "<br/>Ad Soyad: " + form.Ad;
            iletisim.Body += "<br/>Email: " + form.Mail;
            iletisim.Body += "<br/>Mesaj: " + form.Mesaj;
            mailClient.EnableSsl = true;
            iletisim.To.Add("mdilek3496@gmail.com"); //burası info maili
            mailClient.EnableSsl = true;
            mailClient.Send(iletisim);
            return RedirectToAction("iletisim");

        }
        public ActionResult iletisim()
        {
            return View();
        }
        public ActionResult SingleProduct(int id)
        {

            KodmarkData data = new KodmarkData();

            var currentLanguage = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
            SingleProductModel model = new SingleProductModel();
            model = _data.singleProductModelsTr.FirstOrDefault(i => i.ProductId == id);

            switch (currentLanguage)
            {
                case "tr":
                    model = _data.singleProductModelsTr.FirstOrDefault(i => i.ProductId == id);
                    break;
                case "en":
                    model = _data.singleProductModels.FirstOrDefault(i => i.ProductId == id);
                    break;
            }


            return View(model);
        }
        public ActionResult ChangeLanguage(string selectedLanguage, string returnUrl)
        {
            if (selectedLanguage != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(selectedLanguage);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(selectedLanguage);
            }

            HttpCookie cookie = new HttpCookie("language");
            cookie.Value = selectedLanguage;
            Response.Cookies.Add(cookie);


            return Redirect("~" + returnUrl);
        }
    }
}