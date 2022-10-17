﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using YURI.DOMINIO.Excepciones;

namespace YURI.PRESENTER.WEBEXCEPTIONS
{
    public class GeneralExceptionHandler : ExceptionHandlerBase, IExceptionHandler
    {
        public Task Handle(ExceptionContext context)
        {
            var Exception = context.Exception as GeneralException;
            return SetResult(context, StatusCodes.Status500InternalServerError,
                Exception.Message, Exception.Detalle);
        }
    }
}
