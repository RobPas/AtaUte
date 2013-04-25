using AtaUte.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AtaUte.Controllers
{
    //[Authorize]
    [Log]
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/
        
        public ActionResult Search(string name = "french")
        {
            throw new Exception("Something happend");
            var message = Server.HtmlEncode(name);

            return Content(message);
        }


    }
}
