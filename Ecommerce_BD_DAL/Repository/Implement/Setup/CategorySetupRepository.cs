﻿using Ecommerce_BD_DAL.Repository.Interface.Setup;
using Ecommerce_BD_DAL.Repository.Query.Setup;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Ecommerce_BD_DAL.Repository.Implement.Setup
{
    public class CategorySetupRepository:ICategorySetup
    {
        readonly CategorySetupDAL _categorySetupDal = new CategorySetupDAL();

        public DataTable GetAllCategories()
        {
            var data = _categorySetupDal.GetCategoriesAllData();
            return data;
        }
        public bool InsertData(string lang1, string lang2)
        {
            var data = _categorySetupDal.InsertData(lang1,lang2);
            return data;
        }
        public bool UpdateData(int catId, string lang1, string lang2)
        {
            var data = _categorySetupDal.UpdateData(catId, lang1,lang2);
            return data;
        }
    }
}