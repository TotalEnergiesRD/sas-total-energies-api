namespace sas_total_energies_api.Middleware
{
    public class ApiKeyMiddlewareSecurity
    {

        private readonly RequestDelegate _next;
        private const string APIKEY = "TotalApiKey";
        public ApiKeyMiddlewareSecurity(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            if (!context.Request.Headers.TryGetValue(APIKEY, out var extractedApiKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("No se ha proporcionado un ApiKey");
                return;
            }

            var appSettings = context.RequestServices.GetRequiredService<IConfiguration>();

            var apiKey = appSettings.GetValue<string>(APIKEY);

            if (!apiKey.Equals(extractedApiKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Cliente no autorizado");
                return;
            }

            await _next(context);
        }
    }
}
