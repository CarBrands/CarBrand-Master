using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using CarAdmin.Models;
using Common;
using Models;
using Newtonsoft.Json;

namespace CarAdmin.Controllers
{
    public class DataTablesController : BaseController
    {
        //
        // GET: /DataTables/
        private readonly D_CountriesBLL _objCountries =
            AbstractFactory.CreateFunInstance<D_CountriesBLL>("D_CountriesBLL");

        private readonly C_CarMasterBrandBLL _objMasterBrand = AbstractFactory.CreateFunInstance<C_CarMasterBrandBLL>("C_CarMasterBrandBLL");

        private readonly C_BrandIntroductionBLL _objBrandIntr =
            AbstractFactory.CreateFunInstance<C_BrandIntroductionBLL>("C_BrandIntroductionBLL");

        private readonly C_CarBrandBLL _objCarBrand = AbstractFactory.CreateFunInstance<C_CarBrandBLL>("C_CarBrandBLL");
        #region 国家字段维护
        /// <summary>
        /// 所有国家信息
        /// </summary>
        /// <returns></returns>
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

            ViewBag.Tab = ret;
            return View();
        }
        #region 根据ID获取国家信息 废弃

        public JsonResult GetCountriesAll()
        {
            int cId = 0;
            if (!int.TryParse(Request["Id"], out cId))
                return null;
            var dt = _objCountries.GetCountryBycId(cId);
            var ret = JsonConvert.SerializeObject(dt);
            return Json(ret, JsonRequestBehavior.AllowGet);
        }
        #endregion
        /// <summary>
        /// 通过CountryID修改信息
        /// </summary>
        /// <returns></returns>
        public JsonResult EditCountryBycId()
        {
            var model = new D_CountriesEntity();
            model.Name = Request.Params["Name"];
            model.Code = Request.Params["Code"];
            model.OtherName = Request.Params["OtherName"];
            model.LogoUrl = Request.Params["LogoUrl"];
            model.Area = Request.Params["Area"];
            model.CountryID = Convert.ToInt32(Request.Params["CountryID"]);
            if (_objCountries.EditCountryBycId(model))
                return Json(true);
            return Json(false);
        }
        /// <summary>
        /// 根据CountryID修改信息
        /// </summary>
        /// <returns></returns>
        public bool DelCountryBycId()
        {
            return false;
        } 
        #endregion
        #region 主品牌信息维护

        public ActionResult MasterBrand()
        {
            int currentindex = 0;
            if (!int.TryParse(Request["pageIndex"], out currentindex))
                currentindex = 1;

            var ds = _objMasterBrand.GetDataSet(currentindex, InPageSize);
            ViewBag.PageIndex = currentindex;
            ViewBag.Count = ds.Tables[1].Rows[0][0];
            ViewBag.PageSize = InPageSize;
            var ret = JsonConvert.SerializeObject(ds.Tables[0]);

            ViewBag.Tab = ret;
            return View();
        }
        /// <summary>
        /// 编辑主品牌信息
        /// </summary>
        /// <returns></returns>
        public JsonResult EditMasterBrand()
        {
            int mId = 0;
            if (!int.TryParse(Request["MasterBrandID"], out mId))
                mId = 0;
            var model = new C_CarMasterBrandEntity();
            model.MasterBrandName = Request["MasterBrandName"];
            model.MasterBrandOtherName = Request["MasterBrandOtherName"];
            model.BrandEnName = Request["BrandEnName"];
            model.MasterBrandLogo = Request["MasterBrandLogo"];
            model.AllSpells = Request["AllSpells"];
            model.CountryID = Convert.ToInt32(Request["CountryID"]);
            model.CreateTime = Convert.ToDateTime(Request["CreateTime"]);
            model.UpdateTime = Convert.ToDateTime(Request["UpdateTime"]);
            if (mId == 0)
            {
                return Json(_objMasterBrand.InsertMasterBrand(model), JsonRequestBehavior.AllowGet);
            }
            model.MasterBrandID = mId;
            return Json(_objMasterBrand.EditMasterBrand(model), JsonRequestBehavior.AllowGet);
        } 
        #endregion
        #region 主品牌介绍信息维护

        public ActionResult BrandIntroduction()
        {
            int currentindex = 0;
            if (!int.TryParse(Request["pageIndex"], out currentindex))
                currentindex = 1;
            var ds = _objBrandIntr.GetDataSet(currentindex, InPageSize);
            ViewBag.PageIndex = currentindex;
            ViewBag.Count = ds.Tables[1].Rows[0][0];
            ViewBag.PageSize = InPageSize;
            var ret = JsonConvert.SerializeObject(ds.Tables[0]);

            ViewBag.Tab = ret;
            return View();
        } 
        #endregion
        #region 品牌信息维护

        public ActionResult CarBrand()
        {
            int currentindex = 0;
            if (!int.TryParse(Request["pageIndex"], out currentindex))
                currentindex = 1;
            var ds = _objCarBrand.GetDataSet(currentindex, InPageSize);
            ViewBag.PageIndex = currentindex;
            ViewBag.Count = ds.Tables[1].Rows[0][0];
            ViewBag.PageSize = InPageSize;
            var ret = JsonConvert.SerializeObject(ds.Tables[0]);
            ViewBag.Tab = ret;
            return View();
        } 
        #endregion
    }
}
