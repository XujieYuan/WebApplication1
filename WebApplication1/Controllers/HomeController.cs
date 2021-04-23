using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Step()
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

        public ActionResult Waste()
        {
            ViewBag.Message = "All Waste page.";

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

        public ActionResult EWaste()
        {
            ViewBag.Message = "Electronic waste page.";

            return View();
        }

        public ActionResult ConstructionDebris()
        {
            ViewBag.Message = "Construction waste page.";

            return View();
        }

        public ActionResult GreenWaste()
        {
            ViewBag.Message = "Green waste page.";

            return View();
        }

        public ActionResult Tip()
        {
            ViewBag.Message = "Tip page.";

            return View();
        }

        public ActionResult Tip1()
        {
            ViewBag.Message = "Tip 1 page.";

            return View();
        }

        public ActionResult Tip2()
        {
            ViewBag.Message = "Tip 2 page.";

            return View();
        }

        public ActionResult LifeScene()
        {
            ViewBag.Message = "Interaction page.";

            return View();
        }
    }
}