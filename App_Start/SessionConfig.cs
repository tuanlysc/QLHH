using QLHS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLHS.App_Start
{
    public static class SessionConfig
    {
        public static void SetUser(user user)
        {
            HttpContext.Current.Session["user"] = user;
        }
        public static user GetUser()
        {
            return (user)HttpContext.Current.Session["user"];
        }
    }
}