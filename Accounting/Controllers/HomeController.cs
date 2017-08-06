using Accounting.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Accounting.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<AccountingViewModel> accountingViewModels = new List<AccountingViewModel>()
            {
                new AccountingViewModel() { Category = "支出", AccountingDate = new DateTime(2016, 1, 1), Amount = 300 },
                new AccountingViewModel() { Category = "支出", AccountingDate = new DateTime(2016, 1, 2), Amount = 16000 },
                new AccountingViewModel() { Category = "支出", AccountingDate = new DateTime(2016, 1, 3), Amount = 8000 },
            };

            return View(accountingViewModels);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}