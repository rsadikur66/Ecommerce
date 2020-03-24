using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Ecommerce_BD_DAL.Repository.Query.Setup
{
    public class ProductSetupDAL:CommonDAL
    {
        public DataTable GetCategoriesData()
        {
            return Query($@"select Category_Id,Category_Name from Categories");
        }
        public DataTable GetBrandData()
        {
            return Query($@"select Brand_Id,Brand_Name from brands");
        }
    }
}