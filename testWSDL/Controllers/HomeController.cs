using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ServiceModel.Description;
using System.Collections.ObjectModel;
using HelixToolkit.Wpf;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace testWSDL.Controllers
{
    public class HomeController : Controller
    {

        
            
            




        public ContentResult Index()
        {
                                 
                return Content("hello, tang");
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