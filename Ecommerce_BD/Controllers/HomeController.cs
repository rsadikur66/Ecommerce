using Ecommerce_BD_DAL.Repository.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce_BD.Controllers
{
    public class HomeController : Controller
    {
        private IMenu repository;
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

        public ActionResult HomePage()
        {
            return View();
        }

        public JsonResult GetMenuData()
        {
            //string language;
            //string roleCode = "";
            
            var menuData = repository.MenuData();
            string JSONstring = string.Empty;
            JSONstring = JsonConvert.SerializeObject(menuData);
            
            return Json(JSONstring, JsonRequestBehavior.AllowGet);
        }
    }
}