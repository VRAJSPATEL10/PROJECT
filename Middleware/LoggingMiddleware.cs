using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Threading.Tasks;

namespace UserManagementAPI.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var stopwatch = Stopwatch.StartNew();
            await _next(context);
            stopwatch.Stop();

            var request = context.Request;
            var response = context.Response;

            Console.WriteLine($"Request: {request.Method} {request.Path} - Response: {response.StatusCode} - Time Taken: {stopwatch.ElapsedMilliseconds}ms");
        }
    }
}
