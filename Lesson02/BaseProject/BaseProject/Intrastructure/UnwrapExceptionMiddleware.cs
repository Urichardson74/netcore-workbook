using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace BaseProject.Intrastructure
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class UnwrapExceptionMiddleware
    {
        private readonly RequestDelegate next;

        public UnwrapExceptionMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)

        {
            Contract.Ensures(Contract.Result<Task>() != null);
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                ExceptionDispatchInfo.Capture(ex.GetBaseException()).Throw;
            }

          
           
        }
    }

 

}
