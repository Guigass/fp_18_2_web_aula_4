using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fp_stack.api.Custom
{
    public class CustomAuthorize : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Request.Headers["x-api-key"].Count == 0 ||
                context.HttpContext.Request.Headers["x-api-key"].FirstOrDefault() != "1F8Ts6ecx13")
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }
}
