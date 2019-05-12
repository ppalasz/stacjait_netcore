using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace cw1
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            //p.Map("/mapped", HandleMultiSeg);

            //app.Use((context, next) =>
            //{
            //    var cultureQuery = context.Request.Query["culture"];
            //    if (!string.IsNullOrWhiteSpace(cultureQuery))
            //    {
            //        var culture = new CultureInfo(cultureQuery);

            //        CultureInfo.CurrentCulture = culture;
            //        CultureInfo.CurrentUICulture = culture;
            //    }

            //    return next();
            //});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync($"Hello {CultureInfo.CurrentCulture.DisplayName}");
            //});

            app.UseRequestCulture();
            app.UseMultiSeg();

            //to samo bez extension
            app.UseMiddleware<RequestCultureMiddleware>();
        }

       


    }
}
