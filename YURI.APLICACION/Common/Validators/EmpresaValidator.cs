using FluentValidation;
using YURI.APLICACION.DTOs.CRUD_Empresa;

namespace YURI.APLICACION.Common.Validators
{

    public class CrearEmpresaValidator : AbstractValidator<CrearEmpresaParam>
    {
        public CrearEmpresaValidator()
        {
            RuleFor(dmu => dmu.Identificacion).NotEmpty()
             .WithMessage("Debe proporcionar la identificacion de la empresa");
            RuleFor(dmu => dmu.RazonSocial).NotEmpty()
             .WithMessage("Debe proporcionar la razon social de la empresa");
            RuleFor(dmu => dmu.NombreComercial).NotEmpty()
             .WithMessage("Debe proporcionar el nombre comercial de la empresa");
            RuleFor(dmu => dmu.Direccion).NotEmpty()
             .WithMessage("Debe proporcionar la direccion de la empresa");
            RuleFor(dmu => dmu.Email).NotEmpty()
            .WithMessage("Debe proporcionar el correo electronico de la empresa");
            RuleFor(dmu => dmu.Telefono).NotEmpty()
            .WithMessage("Debe proporcionar el numero telefonico de la empresa");
            RuleFor(dmu => dmu.Celular).NotEmpty()
            .WithMessage("Debe proporcionar el numero celular de la empresa");
        }
    }
}
