using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BsuApp.PaymentServiceReference;

namespace BsuApp.Controllers
{
    public class MyServerController : Controller
    {
        //
        // GET: /MyServer/
        public ActionResult Index(string token)
        {
            return View();
        }

        public bool CanUse(string token)
        {
            if (String.IsNullOrEmpty(token))
            {
                return false;
            }
            RegisterClient client = new RegisterClient();
            bool isPaid = client.IsPaid(token, "1c67d8d3-4209-4bdd-ba88-b33230e3b3e2");
            return isPaid;
        }
	}
}