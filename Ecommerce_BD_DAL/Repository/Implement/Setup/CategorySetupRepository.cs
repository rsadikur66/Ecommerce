using Ecommerce_BD_DAL.Repository.Interface.Setup;
using Ecommerce_BD_DAL.Repository.Query.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ecommerce_BD_DAL.Repository.Model.Setup;

namespace Ecommerce_BD_DAL.Repository.Implement.Setup
{
    public class CategorySetupRepository : ICategorySetup
    {
        CategorySetupDAL CatSetDal = new CategorySetupDAL();       

        public bool InsertCategory(CategorySetupModel cat)
        {
            if (cat.CATEGORY_ID == 0)
            {
                var data = CatSetDal.InsertCategory(cat);
                return data;
            }
            else
            {
                var data = CatSetDal.UpdateCategory(cat);
                return data;
            }
            
        }
    }
}