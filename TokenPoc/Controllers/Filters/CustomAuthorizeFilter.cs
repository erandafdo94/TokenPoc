using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace TokenPoc.Controllers
{
    public class CustomAuthorizeFilter : Attribute, IActionFilter
    {
        private readonly string _callerName;

        public CustomAuthorizeFilter(string callerName)
        {
            _callerName = callerName;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
           // throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            context.Result = new UnauthorizedObjectResult("user is unauthorized");
        }


    }
}