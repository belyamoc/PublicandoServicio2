using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Mvc.Models;

namespace Mvc.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            IEnumerable<mvcProductsModel> empList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Products").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<mvcProductsModel>>().Result;
            return View(empList);
        }
    }
}