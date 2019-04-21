using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace CoreExample.Middlewares
{
    public class LogRequestMiddleware
    {
        private readonly RequestDelegate next;

        public LogRequestMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine(context.Request);

            await this.next.Invoke(context);

            Console.WriteLine("We're going back");
        }
    }
}
