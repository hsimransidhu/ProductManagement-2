using AutoMapper;
using PM_DAL;
using PM_BLL;
using ProductManagement_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductManagement_2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product

        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

      
        [HttpGet]
       
        public JsonResult GetProducts()
        {
            ProductService productService = new ProductService();
            var products = productService.GetProducts();

            List<ProductVM> productVMs = new List<ProductVM>();


            Mapper.Map(products, productVMs);

            return Json(productVMs, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetProductById(int Id)
        {
            ProductService productService = new ProductService();
            var product = productService.GetProduct(Id);
            return Json(product, JsonRequestBehavior.AllowGet);

        }

       
        [HttpPost]

        public JsonResult AddProduct(Product product)
        {
            ProductService productService = new ProductService();
            var productAdded = productService.AddProduct(product);

            return Json(productAdded, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]

        public JsonResult UpdateProduct(Product product)
        {
            ProductService productService = new ProductService();
            var productUpdated = productService.UpdateProduct(product);

            return Json(productUpdated, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]

        public JsonResult DeleteProduct(int productId)
        {
            ProductService productService = new ProductService();
            if (productService.DeleteProduct(productId))
            {
                return Json(JsonRequestBehavior.AllowGet);
            }
            return null;
        }

    }
}