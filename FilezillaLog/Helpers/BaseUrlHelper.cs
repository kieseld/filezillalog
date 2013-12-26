using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilezillaLog.Helpers
{
    public static class BaseUrlHelper
    {
        public static string BaseSiteUrl
        {
            get
            {
                HttpContext context = HttpContext.Current;
                string baseUrl = context.Request.Url.Scheme + "://" + context.Request.Url.Authority + context.Request.ApplicationPath.TrimEnd('/') + '/';
                return baseUrl;
            }
        }
    }
}