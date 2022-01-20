using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace API.Middlewares.ErrorsHandlingMiddleware
{
    public class ErrorsHandlingMiddleware
    {
        private readonly RequestDelegate next;

        public ErrorsHandlingMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await next(httpContext);
            }
            catch (Exception)
            {
                httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                string message = "Internal Server Error";
                await HandleExceptionAsync(httpContext, message);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, string message)
        {
            context.Response.ContentType = "application/json";
            await context.Response.WriteAsync(new ErrorDetails
            {
                StatusCode = context.Response.StatusCode,
                Message = message
            }.ToString());
        }
    }
}
