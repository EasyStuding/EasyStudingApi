using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace EasyStudingApi.Filters
{
    public class ControllerExceptionFilterAttribute: ExceptionFilterAttribute
    {
        private readonly Dictionary<Type, IActionResult> _exceptionFilter =
            new Dictionary<Type, IActionResult>()
            {
                {
                    typeof(ArgumentNullException),
                    new StatusCodeResult(404)
                },
                {
                    typeof(ArgumentException),
                    new StatusCodeResult(422)
                },
                {
                    typeof(InvalidOperationException),
                    new StatusCodeResult(400)
                },
                {
                    typeof(UnauthorizedAccessException),
                    new StatusCodeResult(401)
                },
                {
                    typeof(Exception),
                    new StatusCodeResult(500)
                },
            };

        public override void OnException(ExceptionContext context)
        {
            context.Result = _exceptionFilter[context.Exception.GetType()];

            base.OnException(context);
        }

        public override Task OnExceptionAsync(ExceptionContext context)
        {
            context.Result = _exceptionFilter[context.Exception.GetType()];

            return base.OnExceptionAsync(context);
        }
    }
}
