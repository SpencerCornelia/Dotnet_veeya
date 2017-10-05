using System.Threading.Tasks;

namespace Veeya.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VeeyaDbContext context;
        public UnitOfWork(VeeyaDbContext context)
        {
            this.context = context;
        }
        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}