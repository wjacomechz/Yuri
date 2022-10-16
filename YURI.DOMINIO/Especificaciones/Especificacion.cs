using System.Linq.Expressions;

namespace YURI.DOMINIO.Especificaciones
{
    public abstract class Especificacion<T>
    {
        public abstract Expression<Func<T, bool>> Expresion { get; }
        public bool ISSatisfiedBy(T entity)
        {
            Func<T, bool> ExpressionDelegate = Expresion.Compile();
            return ExpressionDelegate(entity);
        }
    }
}
