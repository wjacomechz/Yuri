namespace YURI.DOMINIO.SEGURIDAD.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> GuardarCambiosAsync();
    }
}
