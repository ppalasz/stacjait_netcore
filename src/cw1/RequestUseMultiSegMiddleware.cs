using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace cw1
{
    public class RequestUseMultiSegMiddleware
    {
       

        private readonly RequestDelegate _next;

        public RequestUseMultiSegMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await context.Response.WriteAsync("<div>Map multiple segments.</div>");

            // Call the next delegate/middleware in the pipeline
            await _next(context);
        }
    }
}
