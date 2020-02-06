using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Ecommerce_BD_DAL.Repository.Query
{
    public class MenuQuery:CommonDAL
    {
        public DataTable FormAuthorization(string T_FORM_CODE, string T_USER_ID, string T_ROLE_CODE)
        {
            return Query($"");
        }
        public DataTable GetMenuData()
        {
            return Query($"SELECT CATEGORY_ID,CATEGORY_NAME FROM CATEGORIES");
        }

        public DataTable GetHomeData()
        {
            return Query($"Select * from Products");
        }
        
    }
}