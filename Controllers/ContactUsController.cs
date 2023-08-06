using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstWebsite.Models;

namespace FirstWebsite.Controllers
{
    public class ContactUsController : Controller
    {
        // GET: ContactUs
        public ActionResult Index()
        {
            return View();
        }
        public void ReshapeContactDetails(string FirstName, string LastName, string Email, string Messages)
        {
            Procs.ReshapeContactDetails(FirstName, LastName, Email, Messages);
        }
    }
}