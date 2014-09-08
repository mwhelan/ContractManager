using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContractManager.Web.Controllers
{
    public class JobsController : Controller
    {
        // GET: Jobs
        public ViewResult Index()
        {
            return View();
        }
    }
}