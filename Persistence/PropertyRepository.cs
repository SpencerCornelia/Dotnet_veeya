using System.Threading.Tasks;
using Veeya.Models;

namespace Veeya.Persistence

{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly VeeyaDbContext context;
        public PropertyRepository(VeeyaDbContext context)
        {
            this.context = context;

        }
        public async Task<Property> GetProperty(int id, bool includeRelated = true)
        {
            if (!includeRelated) {
                return await context.Properties.FindAsync(id);
            }
            return await context.Properties.FindAsync(id);
        }

        public void Add(Property property)
        {
            context.Properties.Add(property);
        }

        public void Remove(Property property)
        {
            context.Remove(property);
        }
    }
}