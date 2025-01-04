using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class ContactController : Controller
    {
		// GET: Contact
		Context c = new Context();
		[HttpGet]
        public ActionResult Index()
        {
			
			return View();
        }
        [HttpPost]
        public ActionResult Index(iletisim y)
        {
            c.iletisims.Add(y);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}