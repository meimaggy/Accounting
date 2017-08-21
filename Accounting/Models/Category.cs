using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Accounting.Models
{
    public enum Category
    {
        [Display(Name = "支出")]
        Expend,
        [Display(Name = "收入")]
        Income
    }
}