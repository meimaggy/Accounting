using Accounting.Models;
using Accounting.Models.ViewModels;
using Accounting.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcPaging;

namespace Accounting.Controllers
{
    public class HomeController : Controller
    {
        private readonly AccountBookService _accountBookService;
        private const int PageSize = 20;

        public HomeController()
        {
            var unitOfWork = new EFUnitOfWork();
            _accountBookService = new AccountBookService(unitOfWork);
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AccountingViewModel data)
        {
            if (ModelState.IsValid)
            {
                _accountBookService.Add(data);
                _accountBookService.Save();

                return RedirectToAction("Index");
            }

            return PartialView(data);
        }

        public ActionResult List(int? page)
        {
            var query = _accountBookService.Lookup();

            var pageIndex = page == null || page == 0 ? 0 : (int)page - 1;

            var result = query.OrderByDescending(o => o.AccountingDate).ToPagedList(pageIndex, PageSize);

            return PartialView("_List", result);
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