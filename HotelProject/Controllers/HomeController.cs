using Hotelproject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelProject.Controllers
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

            return PartialView();
        }
        public ActionResult Link()
        {
            return View();
        }
        public ActionResult Create()
        {
            //"warning", "error", "success" and "info".
            TempData["sweetAlert"] = "<script>swal('Header', 'Message','success');</script>";
            return PartialView();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}