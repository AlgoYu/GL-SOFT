using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Policy;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using Microsoft.AspNetCore.Session;

namespace CompanyWebSite.Areas.ManagementSystem.Filter
{
    public class TokenFiler : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.ActionDescriptor.FilterDescriptors.Any(x => x.Filter.GetType() == typeof(AllowAnonymousFilter)))
            {
                return;
            }
            
            if (context.HttpContext.Session.GetString("Token")==null)
            {
                context.HttpContext.Response.Redirect("/ManagementSystem/Login");

            }
            base.OnActionExecuting(context);
        }
    }
}