﻿using System.Web;
using System.Web.Mvc;

namespace Shop_Clothes.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
