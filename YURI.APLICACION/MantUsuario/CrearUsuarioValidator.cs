using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YURI.APLICACION.MantUsuario
{
    public class CrearUsuarioValidator : AbstractValidator<CrearUsuarioInputPort>
    {
        public CrearUsuarioValidator()
        {
            RuleFor(dmu => dmu.NombreCompleto).NotEmpty()
                .WithMessage("Debe proporcionar el nombre del usuario");
            RuleFor(dmu => dmu.Alias).NotEmpty()
             .WithMessage("Debe proporcionar el alias del usuario");
            RuleFor(dmu => dmu.Pass).NotEmpty()
             .WithMessage("Debe proporcionar la contraseña del usuario");
            RuleFor(dmu => dmu.Email).NotEmpty()
             .WithMessage("Debe proporcionar el correo electronico del usuario");
            RuleFor(dmu => dmu.IdTipoUsuario).NotEmpty()
             .WithMessage("Debe proporcionar el tipo de usuario");
        }


    }
}
