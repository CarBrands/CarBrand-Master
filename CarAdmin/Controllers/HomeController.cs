using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Common;

namespace CarAdmin.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        private readonly D_CountriesBLL _objCountries =
            AbstractFactory.CreateFunInstance<D_CountriesBLL>("D_CountriesBLL");
        public HomeController()
        {
        }

        public ActionResult Index()
        {
            //var countries = _objCountries.GetDateTable();
            //ViewData["Country"] = countries;
            return View();
        }

    }
}
