using FluentValidation;

namespace YURI.APLICACION.CRUD_Usuario.Crear
{
    public class CrearUsuarioValidator : AbstractValidator<CrearUsuarioInputPort>
    {
        public CrearUsuarioValidator()
        {
            RuleFor(dmu => dmu.RequestData.Alias).NotEmpty()
             .WithMessage("Debe proporcionar el alias del usuario");
            RuleFor(dmu => dmu.RequestData.Pass).NotEmpty()
             .WithMessage("Debe proporcionar la contraseña del usuario");
            RuleFor(dmu => dmu.RequestData.Email).NotEmpty()
             .WithMessage("Debe proporcionar el correo electronico del usuario");
            RuleFor(dmu => dmu.RequestData.IdTipoUsuario).NotEmpty()
             .WithMessage("Debe proporcionar el tipo de usuario");
        }


    }
}
