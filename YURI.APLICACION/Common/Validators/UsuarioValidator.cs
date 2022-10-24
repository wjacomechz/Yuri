using FluentValidation;
using YURI.APLICACION.DTOs.CRUD_Usuario;

namespace YURI.APLICACION.Common.Validators
{
    public class CrearUsuarioValidator: AbstractValidator<CrearUsuarioParam>
    {
        public CrearUsuarioValidator()
        {
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
