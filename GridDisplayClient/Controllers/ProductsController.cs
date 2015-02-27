using System.Web.Mvc;
using GridDisplayClient.Models;
using GridDisplayClient.ServiceReference1;
using GridDisplayClient.ServiceReference2;

namespace GridDisplayClient.Controllers
{
    public class ProductsController : Controller
    {

        readonly private ServiceReference1.GridDisplayClient serviceReference1;
        readonly private CategoriesClient serviceReference2;

        public ProductsController()
        {
            serviceReference1 = new ServiceReference1.GridDisplayClient();
            serviceReference2 = new CategoriesClient();
        }
       
        public ActionResult Index(string filter)
        {
            return View("Index",serviceReference1.GetProducts(filter));
        }

        public ActionResult Archive(int productId)
        {
            serviceReference1.Archive(productId);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public ActionResult Create()
        {
            //ViewData["GroupsList"] = new MultiSelectList(myGroups.GetAllGroups(), "GroupID", "GroupName");
            ViewData["CategoriesId"] = new MultiSelectList(serviceReference2.GetCategories(), "Id", "Name");
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
            product.Categories = productViewModel.CategoriesId;

            serviceReference1.Create(product);

            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public ActionResult Details(int productId)
        {
            var productDto = serviceReference1.GetDetails(productId);
            var productViewModel = new ProductViewModel();

            productViewModel.ProductId = productDto.Id;
            productViewModel.Name = productDto.Name;
            productViewModel.Price = productDto.Price;
            productViewModel.CategoriesId = productDto.Categories;

            ViewData["CategoriesId"] = new MultiSelectList(serviceReference2.GetCategories(), "Id", "Name");

            return View(productViewModel);
        }

        [HttpGet]
        public ActionResult Edit(int productId)
        {
            var productDto = serviceReference1.GetDetails(productId);

            var productViewModel = new ProductViewModel();

            productViewModel.ProductId = productDto.Id;
            productViewModel.Name = productDto.Name;
            productViewModel.Price = productDto.Price;
            productViewModel.CategoriesId = productDto.Categories;

            ViewData["CategoriesId"] = new MultiSelectList(serviceReference2.GetCategories(), "Id", "Name");

            return View(productViewModel);
        }

        [HttpPost]
        public ActionResult Edit(ProductViewModel productViewModel)
        {
            var product = new ProductDto();

            product.Id = productViewModel.ProductId;
            product.Name = productViewModel.Name;
            product.Price = productViewModel.Price;
            product.Categories = productViewModel.CategoriesId;

            serviceReference1.Save(product);

            return RedirectToAction("Index");
        }
    }
}