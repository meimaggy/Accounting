using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Accounting.Views.Home
{
    public class ValidController : Controller
    {
        public ActionResult AmountValid(int amount)
        {
            bool isValidate = amount >= 1 && amount<= Int32.MaxValue;
            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AccountingDateValid(string accountingDate)
        {
            bool isValidate = Convert.ToDateTime(accountingDate) <= DateTime.Today;
            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }
    }
}