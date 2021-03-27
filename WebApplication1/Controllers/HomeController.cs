using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Composting()
        {
            ViewBag.Message = "Composting page.";

            return View();
        }

        public ActionResult Recycle()
        {
            ViewBag.Message = "Recycle page.";

            return View();
        }

        public ActionResult LSWaste()
        {
            ViewBag.Message = "Liquid or solid household waste page.";

            return View();
        }

        public ActionResult MedicalWaste()
        {
            ViewBag.Message = "Medical waste page.";

            return View();
        }

        public ActionResult GreenWaste()
        {
            ViewBag.Message = "Green waste page.";

            return View();
        }

        //public ActionResult CategoryEdit()
        //{
        //    ViewBag.Message = "Category Edit page.";

        //    return View();
        //}
    }
}