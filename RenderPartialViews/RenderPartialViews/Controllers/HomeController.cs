using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RenderPartialViews.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult GetAddress()
        {
            return PartialView("_address"); 
        }

      
        [ChildActionOnly]
        public ActionResult GetAddressAction()
        {
            return PartialView("_address"); 
        }

        [ChildActionOnly]        
        public ActionResult ActionWithParameter(string category)
        {
            if(category == "billing")
                return PartialView("_billingaddress");

            return PartialView("_shippingaddress");
        }        
        
        
        public PartialViewResult GetAddressForjQuery(string category)
        {
            return PartialView("_address");
        }

        
    }
}
