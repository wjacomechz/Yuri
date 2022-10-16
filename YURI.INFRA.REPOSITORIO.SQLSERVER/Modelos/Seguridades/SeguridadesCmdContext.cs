using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YURI.INFRA.REPOSITORIO.SQLSERVER.Modelos.Seguridades
{
   
    public sealed partial class SeguridadesCmdContext : DbContext
    {
        public SeguridadesCmdContext()
           : base()
        {
        }

        public SeguridadesCmdContext(DbContextOptions<SeguridadesCmdContext> options)
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
