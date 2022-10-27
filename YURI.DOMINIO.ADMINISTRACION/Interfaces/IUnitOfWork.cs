namespace YURI.DOMINIO.ADMINISTRACION.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> GuardarCambiosAsync();
    }
}
