using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingProject.Controllers
{
    public class TBankingController : Controller
    {
        //
        // GET: /TBanking/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TransferFunds()
        {
            return View();
        }
        public ActionResult PayBills()
        {
            return View();
        }
        public ActionResult ViewTransactions()
        {
            return View();
        }
        public ActionResult AccountDetails(string id)
        {
            return Content(id); // View();
        }


    }
}
