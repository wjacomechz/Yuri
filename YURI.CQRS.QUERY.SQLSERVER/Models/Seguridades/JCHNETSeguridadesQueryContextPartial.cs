using Microsoft.EntityFrameworkCore;
using YURI.CQRS.QUERY.DTOs.Seguridades;

namespace YURI.CQRS.QUERY.SQLSERVER.Models.Seguridades
{
    public sealed partial class JCHNETSeguridadesQueryContext
    {
        private DbSet<UsuarioResultQueryDto> UsuarioResultQueryDto { get; set; }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioResultQueryDto>().HasNoKey().ToView(null);

        }
    }
}
