using CautionSououmission.Shared;
using Microsoft.EntityFrameworkCore;

namespace Crudblazorserve2.Services
{
    public class BeneficiaireService:ServiceBase<Beneficiaire>
    {
        public BeneficiaireService(ApplicationDbContext context):base(context)
        {

        }
        
        public DbSet<Beneficiaire> beneficiaires { get; set; }
    }
}
