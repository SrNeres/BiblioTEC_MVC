using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BiblioTec_MVC.Controllers
{
    public class EmprestimoController : Controller
    {
        // GET: Emprestimo
        public ActionResult Index()
        {
            return View("EmprestimoIndex");
        }
    }
}