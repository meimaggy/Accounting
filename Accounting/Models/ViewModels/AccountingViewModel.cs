﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Accounting.Models.ViewModels
{
    public class AccountingViewModel
    {        
        public string Category { get; set; }
        public DateTime AccountingDate { get; set; }
        public int Amount { get; set; }
    }
}