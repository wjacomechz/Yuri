using Microsoft.AspNetCore.Mvc.Filters;

namespace YURI.WEBEXCEPTIONS.PRESENTADOR
{
    public interface IExceptionHandler
    {
        Task Handle(ExceptionContext context);
    }
}
