using Microsoft.AspNetCore.Builder;

namespace cw1
{
    public static class RequestUseMultiSegMiddlewareExtensions
    {
        public static IApplicationBuilder UseMultiSeg(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestUseMultiSegMiddleware>();
        }
    }
}