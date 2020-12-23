using CrystalDecisions.CrystalReports.Engine;
using Ecommerce_BD_DAL.Repository.Interface.Setup;
using Ecommerce_BD_DAL.Repository.Query.Setup;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Ecommerce_BD.Controllers.Setup
{
    public class CategorySetupController : Controller
    {
        public ICategorySetup repository;
        public CategorySetupDAL dal = new CategorySetupDAL();
        public CategorySetupController(ICategorySetup _repository)
        {
            repository = _repository;
        }
        // GET: CategorySetup
        public ActionResult Index()
        {
            return View();
        }

        public string InsertData(string T_LANG1_NAME, string T_LANG2_NAME)
        {
            string Message = "";
            try
            {
                if (repository.InsertData(T_LANG1_NAME, T_LANG2_NAME))
                {
                    Message = "Data Insert Successfully!";
                }               
            }
            catch (Exception exc)
            {

                return Message="Data Not Insert!";
            }            
            return Message;           
           
        }

        public string UpdateData(int CATEGORY_ID, string T_LANG1_NAME, string T_LANG2_NAME)
        {
            string Message = "";
            try
            {
                if (repository.UpdateData(CATEGORY_ID, T_LANG1_NAME, T_LANG2_NAME))
                {
                    Message = "Data Updated Successfully!";
                }
            }
            catch (Exception exc)
            {

                return Message = "Data Not updated!";
            }
            return Message;

        }
        public string DeleteCatData(int CATEGORY_ID)
        {
            string Message = "";
            try
            {
                if (repository.DeleteData(CATEGORY_ID))
                {
                    Message = "Data Deleted Successfully!";
                }
            }
            catch (Exception exc)
            {

                return Message = "Data Not deleted!";
            }
            return Message;

        }



        public ActionResult GetAllCategoriesData()
        {
            try
            {
                var allCategories = repository.GetAllCategories();
                string JSONstring = string.Empty;
                JSONstring = JsonConvert.SerializeObject(allCategories);
                return Json(JSONstring, JsonRequestBehavior.AllowGet);
            }
            catch (Exception exc)
            {
                return Json(exc.Message, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult PrintReport()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dal.GetReportData();
                dt.WriteXmlSchema(Server.MapPath("~/Report/T74001.xml"));
                dt.TableName = "CATEGORIES";
                ReportDocument rd = new ReportDocument();
                rd.Load(Path.Combine(Server.MapPath("~/Report"), "CrystalReport1.rpt"));
                rd.SetDataSource(dt);
                Response.Buffer = false;
                Response.ClearContent();
                Response.ClearHeaders();


                Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                stream.Seek(0, SeekOrigin.Begin);
                return File(stream, "application/pdf");
            }
            catch (Exception exc)
            {
                return Json(exc.Message, JsonRequestBehavior.AllowGet);
            }
        }
    }
}