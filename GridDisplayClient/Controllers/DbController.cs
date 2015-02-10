using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace GridDisplayClient.Controllers
{
    public class DbController : Controller
    {
        // GET: Db
        public ActionResult Index()
        {
            ServiceReference1.GridDisplayClient obj = new ServiceReference1.GridDisplayClient();
            return View(obj.GetProducts());
        }
    }
}