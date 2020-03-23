using Ecommerce_BD_DAL.Repository.Interface.Setup;
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

        public bool InsertData()
        {
            return true;
        }
    }
}