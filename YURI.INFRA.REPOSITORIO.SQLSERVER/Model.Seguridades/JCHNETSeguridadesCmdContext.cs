using Microsoft.EntityFrameworkCore;

namespace YURI.INFRA.REPOSITORIO.SQLSERVER.Model.Seguridades
{
    public sealed partial class JCHNETSeguridadesCmdContext : DbContext
    {
        public JCHNETSeguridadesCmdContext()
           : base()
        {
        }

        public JCHNETSeguridadesCmdContext(DbContextOptions<JCHNETSeguridadesCmdContext> options)
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
