using Microsoft.EntityFrameworkCore;

namespace YURI.REPOSITORIO.SQLSERVER.Modelos.Seguridad
{
    public sealed partial class SeguridadCmdContext : DbContext
    {
        public SeguridadCmdContext()
            : base()
        {
        }

        public SeguridadCmdContext(DbContextOptions<SeguridadCmdContext> options)
            :base(options)
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
