using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YURI.APLICACION.Common.Behaviors
{
    public class ValidationBehavior<TRequest, TResponse> :
        IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        readonly IEnumerable<IValidator<TRequest>> Validator;

        public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators) =>
            Validator = validators;

        /// <summary>
        /// Ayuda a validar las peticiones
        /// </summary>
        /// <param name="request"></param>
        /// <param name="next"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<TResponse> Handle(TRequest request, 
            RequestHandlerDelegate<TResponse> next, 
            CancellationToken cancellationToken)
        {
            var Failrules = Validator
               .Select(v => v.Validate(request))
               .SelectMany(r => r.Errors)
               .Where(f => f != null)
               .ToList();
            if (Failrules.Any())
                throw new ValidationException(Failrules);
            return next();
        }
    }
}
