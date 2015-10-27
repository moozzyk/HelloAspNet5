using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;

namespace HelloWorld
{
    public class Startup
    {
        public void Configure(IApplicationBuilder appBuilder)
        {
            appBuilder.Run(async context => 
            {
                await context.Response.WriteAsync("Hello Asp.Net 5!");
            });
        }
    }
}
