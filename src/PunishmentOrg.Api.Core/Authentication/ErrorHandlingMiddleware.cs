using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Utility;
using Utility.Exceptions;

namespace Anu.PunishmentOrg.Api.Authentication
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exception)
            {
                await HandleExceptionAsync(context, exception);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var responseMessage = new Anu.Commons.ServiceModel.ServiceResponse.ResponseMessage();
            var result = new Commons.ServiceModel.ServiceResponse.Result();

            try
            {
                result = ((AnuExceptions)exception).result;
            }
            catch (Exception innerException)
            {
                result = AnuResult.Error.GetResult(description: "unhandledexception" + exception.Message);
            }
            finally
            {
                responseMessage.Result = result;
            }

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)System.Net.HttpStatusCode.InternalServerError;
            return context.Response.WriteAsync(System.Text.Json.JsonSerializer.Serialize(responseMessage));
        }
    }
}