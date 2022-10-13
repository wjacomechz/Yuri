using Microsoft.EntityFrameworkCore;

namespace YURI.CQRS.QUERY.SQLSERVER.Models.Seguridades
{
   
    public sealed partial class JCHNETSeguridadesQueryContext : DbContext
    {

        public JCHNETSeguridadesQueryContext()
           : base()
        {
        }


        public JCHNETSeguridadesQueryContext(DbContextOptions<JCHNETSeguridadesQueryContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("data source=***;initial catalog=***;user id=**;password=***");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}
