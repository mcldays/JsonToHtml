using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JsonToHtml.Utilities;

namespace JsonToHtml.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            JsonToModel js =  new JsonToModel();
           var model = js.Distribute();
            return View(model);
        }

    }
}