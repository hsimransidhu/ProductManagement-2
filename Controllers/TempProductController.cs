using System;
using PM_BLL;
using ProductManagement_2;
using PM_DAL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductManagement_2.Controllers
{
    public class TempProductController : Controller
    {
        // GET: TempProduct
        public ActionResult Index()
        {
            ProductService productService = new ProductService();
            var products = productService.GetProducts();
            return View(products);
        }

    }
}