using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Accounting.Models.ViewModels
{
    public class AccountingViewModel
    {
        [Display(Name = "類別")]
        [Required(ErrorMessage = "{0}為必選項目")]
        public Category Category { get; set; }

        [Display(Name = "日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Required(ErrorMessage = "{0}為必填欄位")]
        [Remote("AccountingDateValid", "Valid", ErrorMessage = "{0}不得大於今天日期")]
        public DateTime AccountingDate { get; set; }

        [Display(Name = "金額")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        [Required(ErrorMessage = "{0}為必填欄位")]
        [Remote("AmountValid", "Valid", ErrorMessage = "{0}請輸入正整數，範圍 1 ~ 2,147,483,647")]
        public int Amount { get; set; }

        [Display(Name = "備註")]
        [Required(ErrorMessage = "{0}為必填欄位")]
        [StringLength(100, ErrorMessage = "{0}最多輸入 {1} 字元")]
        public string Remark { get; set; }
    }
}