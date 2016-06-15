using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FutebolAdmin.Models
{
    public static class SessionHelper
    {
        public static int GetLogin()
        {
            return (HttpContext.Current.Session["Login"] == null) ? 0 : (int)HttpContext.Current.Session["Login"];
        }
    }
}