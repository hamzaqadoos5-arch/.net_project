
namespace Middleware.CustomMiddleware
{
    public class MyCustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("My custom Middlewere-Starts\n");
            await next(context);
            await context.Response.WriteAsync("My custom Middlewere-Ends\n");

        }
    }

    public static class CustomMiddlewareExtension
    {
        public static IApplicationBuilder UseMyCustomMiddleware
        (this IApplicationBuilder app)
        {
            return app.UseMiddleware<MyCustomMiddleware>();
        }



    }


}
