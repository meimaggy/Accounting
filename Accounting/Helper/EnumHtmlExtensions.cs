using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Accounting.Helper
{
    public static class EnumHtmlExtensions
    {
        public static string GetEnumDisplayName(this HtmlHelper helper, Enum enumType)
        {
            return enumType.GetType()
                        .GetMember(enumType.ToString())
                        .First()
                        .GetCustomAttribute<DisplayAttribute>()
                        .Name;
        }
    }
}