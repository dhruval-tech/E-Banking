using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_Banking_Client.Service1;

namespace E_Banking_Client.Controllers
{
    public class HomeController : Controller
    {
        Service1Client client = new Service1Client();
        public ActionResult Index()
        {
            ViewBag.Message = client.GetData(1);
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
    }
}