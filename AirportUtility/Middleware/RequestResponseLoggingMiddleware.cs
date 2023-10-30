using Serilog;

namespace AirportUtility.Middleware
{
    public class RequestResponseLoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestResponseLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            // Log the request
            var request = context.Request;
            var requestMessage = $"{request.Method} {request.Host}{request.Path}{request.QueryString}";
            Log.Information("Request: {Request}", requestMessage);

            // Capture the response
            var originalBodyStream = context.Response.Body;
            using (var responseBody = new MemoryStream())
            {
                context.Response.Body = responseBody;
                try
                {
                    await _next(context);

                    // Log the response
                    var response = FormatResponse(context.Response);
                    Log.Information("Response: {Response}", response);
                }
                catch (Exception ex)
                {
                    // Log the exception
                    Log.Error(ex, "An unhandled exception occurred while processing the request.");

                    // Re-throw the exception to allow it to be handled by the global error handler
                    throw;
                }

                responseBody.Seek(0, SeekOrigin.Begin);
                await responseBody.CopyToAsync(originalBodyStream);
            }
        }

        private string FormatResponse(HttpResponse response)
        {
            response.Body.Seek(0, SeekOrigin.Begin);
            var body = new StreamReader(response.Body).ReadToEnd();
            //response.Body.Seek(0, SeekOrigin.Begin);
            return $"Status: {response.StatusCode}, Body: {body}";
        }

    }
}
