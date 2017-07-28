﻿using System.Web.Mvc;
using System.Web.Routing;
using Portal.CMS.Web.Architecture.Helpers;

namespace Portal.CMS.Web.Architecture.ActionFilters
{
    public sealed class AdminFilter : ActionFilterAttribute
    {
        private ActionFilterResponseType responseType;

        public AdminFilter(ActionFilterResponseType modal)
        {
            this.responseType = modal;
        }

        public ActionFilterResponseType actionFilterResponseType { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!UserHelper.IsAdmin)
            {
                if (responseType == ActionFilterResponseType.Page)
                {
                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary { { "action", "Index" }, { "controller", "Home" }, { "area", "" } });
                }
                else
                {
                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary { { "action", "Login" }, { "controller", "Authentication" }, { "area", "Admin" } });
                }
            }
        }
    }
}