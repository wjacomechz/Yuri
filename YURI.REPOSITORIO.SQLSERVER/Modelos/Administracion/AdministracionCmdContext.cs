using Microsoft.EntityFrameworkCore;

namespace YURI.REPOSITORIO.SQLSERVER.Modelos.Administracion
{
    public sealed partial class AdministracionCmdContext : DbContext
    {
        public AdministracionCmdContext()
            : base()
        {
        }

        public AdministracionCmdContext(DbContextOptions<AdministracionCmdContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("data source=***;initial catalog=***;user id=***;password=***");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
