using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABCompany.Complaint.Controllers
{
    public class ContactController : Controller
    {
        /// <summary>
        /// Contact page
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}