using CautionSououmission.Shared;
using Microsoft.EntityFrameworkCore;

namespace Crudblazorserve2
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public virtual DbSet<Typearticle> Typearticles {get;set;}
        public virtual DbSet<Donneurordre>Donneurordres {get;set;}
        public virtual DbSet<Beneficiaire> Beneficiaires{get;set;}
        public virtual DbSet<Caution>Cautions {get;set;}

    }
}
