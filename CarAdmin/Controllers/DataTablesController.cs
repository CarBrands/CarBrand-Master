using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using CarAdmin.Models;
using Common;
using Newtonsoft.Json;

namespace CarAdmin.Controllers
{
    public class DataTablesController : BaseController
    {
        //
        // GET: /DataTables/
        private readonly D_CountriesBLL _objCountries =
            AbstractFactory.CreateFunInstance<D_CountriesBLL>("D_CountriesBLL");

        public ActionResult Index()
        {
            int currentindex = 0;
            if (!int.TryParse(Request["pageIndex"], out currentindex))
                currentindex = 1;

            var ds = _objCountries.GetDateSet(currentindex, InPageSize);

            ViewBag.PageIndex = currentindex;
            ViewBag.Count = ds.Tables[1].Rows[0][0];
            ViewBag.PageSize = InPageSize;
            var ret = JsonConvert.SerializeObject(ds.Tables[0]);
            //return Json(ret, JsonRequestBehavior.AllowGet);

            ViewBag.Tab = ret;
            return View();
        }

        public JsonResult GetCountriesAll()
        {
            int cId = 0;
            if (!int.TryParse(Request["Id"], out cId))
                return null;

            var dt = _objCountries.GetCountryBycId(cId);
            
            var ret = JsonConvert.SerializeObject(dt);
            return Json(ret, JsonRequestBehavior.AllowGet);
        }
    }
}
