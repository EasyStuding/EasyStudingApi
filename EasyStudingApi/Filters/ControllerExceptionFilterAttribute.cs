using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using EasyStudingServices.Services;

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
                    new StatusCodeResult(403)
                }
            };

        public override void OnException(ExceptionContext context)
        {
            context = GetStatusCodeResult(context);

            base.OnException(context);
        }

        public override Task OnExceptionAsync(ExceptionContext context)
        {
            context = GetStatusCodeResult(context);

            return base.OnExceptionAsync(context);
        }

        private ExceptionContext GetStatusCodeResult(ExceptionContext context)
        {
            try
            {
                context.Result = 
                    _exceptionFilter[context.Exception.GetType()];

                return context;
            }
            catch
            {
                context.Result = 
                    new StatusCodeResult(500);

                return context;
            }
            finally
            {
                LogService
                    .UpdateLogFile(context.Exception);
            }
        }
    }
}
