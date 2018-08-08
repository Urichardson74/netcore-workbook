using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace BaseProject.Intrastructure
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CalculateTime
    {
        private readonly RequestDelegate next;

        public CalculateTime(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            var start = new Stopwatch();
            start.Start();
            await next(httpContext);
            start.Stop();
            Console.WriteLine(start.ElapsedMilliseconds);
           
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class CalculateTimeExtensions
    {
        public static IApplicationBuilder UseMiddlewareClassTemplate(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CalculateTime>();
        }
    }
}
