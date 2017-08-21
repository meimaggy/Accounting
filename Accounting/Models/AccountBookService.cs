using Accounting.Models.ViewModels;
using Accounting.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Accounting.Models
{
    public class AccountBookService
    {
        private readonly IRepository<AccountBook> _accountBookRep;
        private readonly IUnitOfWork _unitOfWork;

        public AccountBookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _accountBookRep = new Repository<AccountBook>(unitOfWork);
        }

        public IEnumerable<AccountingViewModel> Lookup()
        {
            var query = _accountBookRep.LookupAll();
            var result = query.Select(accountBook => new AccountingViewModel()
            {
                 Category = accountBook.Categoryyy == 0 ? "支出" : "收入",
                 AccountingDate = accountBook.Dateee,
                 Amount = accountBook.Amounttt,
            }).ToList();
            return result;
        }


        public void Add(AccountingViewModel accountingViewModel)
        {
            var result = new AccountBook()
            {
                Id = Guid.NewGuid(),
                Categoryyy = accountingViewModel.Category == "支出" ? 0 : 1,
                Dateee = accountingViewModel.AccountingDate,
                Amounttt = accountingViewModel.Amount,
                Remarkkk = "",
            };

            Add(result);
        }

        public void Add(AccountBook accountBook)
        {
            _accountBookRep.Create(accountBook);            
        }

        public void Save()
        {
            _unitOfWork.Save();
        }
    }
}