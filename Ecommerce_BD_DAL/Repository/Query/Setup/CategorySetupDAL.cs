using Ecommerce_BD_DAL.Repository.Model.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce_BD_DAL.Repository.Query.Setup
{
    public class CategorySetupDAL : CommonDAL
    {
        public bool InsertCategory(CategorySetupModel cat)
        {
            Command($"insert into CATEGORIES(T_LANG1_NAME,T_LANG2_NAME) values(N'{cat.T_LANG1_NAME}','{cat.T_LANG2_NAME}')");
            return true;
        }


        public bool UpdateCategory(CategorySetupModel cat)
        {
            Command($"insert into CATEGORIES(T_LANG1_NAME,T_LANG2_NAME) values('{cat.T_LANG1_NAME}','{cat.T_LANG2_NAME}')");
            return true;
        }
    }
}