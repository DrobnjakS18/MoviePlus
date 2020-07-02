
using FluentValidation;
using Microsoft.AspNetCore.Http;
using MoviePlus.Application.Exceptions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePlus.API.Core
{
    public class GlobalExceptionHandler
    {
        private readonly RequestDelegate _next;

        public GlobalExceptionHandler(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                httpContext.Response.ContentType = "application/json";
                object response = null;
                var statusCode = StatusCodes.Status500InternalServerError;


                switch (ex)
                {
                    case UnauthorizedException _:
                        statusCode = StatusCodes.Status403Forbidden;
                        response = new
                        {
                            message = "You are not allowed to execute this operation"
                        };
                        break;
                    case NotFoundException _:
                        statusCode = StatusCodes.Status404NotFound;
                        response = new
                        {
                            message = "Not found"
                        };
                        break;
                    case ValidationException validation:
                        statusCode = StatusCodes.Status422UnprocessableEntity;
                        response = new
                        {

                            message = "Validation failed",
                            errors = validation.Errors.Select(x => new {
                                x.PropertyName,
                                x.ErrorMessage
                            })
                        };
                        break;

                }

                httpContext.Response.StatusCode = statusCode;

                if (response != null)
                {
                    await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(response));
                    return;
                }

                await Task.FromResult(httpContext.Response);
            }
        }
    }
}
