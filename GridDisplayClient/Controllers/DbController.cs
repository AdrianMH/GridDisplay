using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            return View("view",obj.GetProducts("search"));
        }

        public ActionResult Archive()
        {
            ServiceReference1.GridDisplayClient archive = new ServiceReference1.GridDisplayClient();
            archive.Archive(1);
            return View("view", archive.Archive(1));
        }
    }
}