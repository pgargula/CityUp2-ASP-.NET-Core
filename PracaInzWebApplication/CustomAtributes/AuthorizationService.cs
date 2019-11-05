using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PracaInzWebApplication.CustomAtributes
{
    public class AuthorizeAttribute : TypeFilterAttribute
    {
        public AuthorizeAttribute(params string[] claim) : base(typeof(AuthorizeFilter))
        {
            Arguments = new object[] { claim };
        }
    }

    public class AuthorizeFilter : IAuthorizationFilter
    {
        private readonly string[] _claims;
        public AuthorizeFilter(params string[] claims)
        {
            _claims = claims;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            bool hasClaim = false;
            var claimsIndentity = context.HttpContext.User.Identity as ClaimsIdentity;
            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                if (_claims.Length > 0)
                {
                    foreach (var claim in _claims)
                    {
                        if (context.HttpContext.User.HasClaim("Role", claim))
                            hasClaim = true;
                    }
                    if (!hasClaim)
                        if (context.HttpContext.Request.IsAjaxRequest())
                            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                        else
                            context.Result = new RedirectResult("~/Home/Index");
                }
                
            }
            else
                if (context.HttpContext.Request.IsAjaxRequest())
                    context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                else
                    context.Result = new RedirectResult("~/Home/Index");
            return;
        }
    }
}
