using Ecommerce_BD_DAL.Repository.Interface.Setup;
using Ecommerce_BD_DAL.Repository.Model.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce_BD.Controllers.Setup
{
    public class CategorySetupController : Controller
    {
        public ICategorySetup repository;

        public CategorySetupController(ICategorySetup _repository)
        {
            repository = _repository;
        }
        // GET: CategorySetup
        public ActionResult Index()
        {
            return View();
        }

        public bool InsertData(CategorySetupModel cat)
        {
            var del = repository.InsertCategory(cat);
            //return Json(del, JsonRequestBehavior.AllowGet);
            return true;
        }
    }
}