using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TransactionLog.Controllers
{
    public class swaggerController : Controller
    {
        // GET: swagger
        public ActionResult Index()
        {

            string baseurl = Request.Url.Scheme + "://"
                + Request.Url.Authority
                + Request.ApplicationPath.TrimEnd('/') + "/";

            return Redirect(baseurl + "swagger");
        }
    }
}