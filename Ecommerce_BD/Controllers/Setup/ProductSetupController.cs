﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ecommerce_BD_DAL.Repository.Interface;
using Ecommerce_BD_DAL.Repository.Interface.Setup;
using Newtonsoft.Json;

namespace Ecommerce_BD.Controllers.Setup
{
    public class ProductSetupController : Controller
    {
        public IProductSetup repository;

        public ProductSetupController(IProductSetup _repository)
        {
            repository = _repository;
        }
        // GET: ProductSetup
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetCategories()
        {
            try
            {
                var itemCategoriesData = repository.GetCategoriesData();
                string JSONstring = string.Empty;
                JSONstring = JsonConvert.SerializeObject(itemCategoriesData);
                return Json(JSONstring, JsonRequestBehavior.AllowGet);
            }
            catch (Exception exc)
            {
                return Json(exc.Message, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult GetBrands()
        {
            try
            {
                var itemBrandsData = repository.GetBrandData();
                string JSONstring = string.Empty;
                JSONstring = JsonConvert.SerializeObject(itemBrandsData);
                return Json(JSONstring, JsonRequestBehavior.AllowGet);
            }
            catch (Exception exc)
            {
                return Json(exc.Message, JsonRequestBehavior.AllowGet);
            }
        }
    }
}