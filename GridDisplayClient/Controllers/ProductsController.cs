using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

using GridDisplayClient.Models;
using GridDisplayClient.ServiceReference1;

namespace GridDisplayClient.Controllers
{
    public class ProductsController : Controller
    {

        readonly private ServiceReference1.GridDisplayClient serviceReference;

        public ProductsController()
        {
            serviceReference = new ServiceReference1.GridDisplayClient();
        }
       
        // GET: Db
        public ActionResult Index()
        {
            return View("Index",serviceReference.GetProducts("search"));
        }

        public ActionResult Archive(int productId)
        {
            serviceReference.Archive(productId);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProductViewModel productViewModel)
        {
            //intra product(productviewmodel)
            //metoda din servicereference.create primeste de tip gridrow
            var product = new ProductDto();

            product.Name = productViewModel.Name;
            product.Price = productViewModel.Price;

            serviceReference.Create(product);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int productId)
        {
            return View();
        }
        
    }
}