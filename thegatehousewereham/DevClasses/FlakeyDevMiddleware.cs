using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thegatehousewereham.DevClasses
{
    public class FlakeyDevMiddleware
    {
        RequestDelegate _next;
        Random _random;

        public FlakeyDevMiddleware(RequestDelegate next)
        {
            this._next = next;
            this._random = new Random(1234);
        }

        public async Task InvokeAsync(HttpContext ctx)
        {
            int x = _random.Next(1000);
            if (x < 950)
                await _next(ctx);
            else
                throw new SystemException("Random Middleware Exception.");
        }
    }
}
