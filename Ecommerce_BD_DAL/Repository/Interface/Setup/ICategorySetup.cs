using Ecommerce_BD_DAL.Repository.Model.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ecommerce_BD_DAL.Repository.Interface.Setup
{
    public interface ICategorySetup
    {
        bool InsertCategory(CategorySetupModel cat);
    }
}
