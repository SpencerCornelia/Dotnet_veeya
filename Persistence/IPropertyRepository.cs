using System.Threading.Tasks;
using Veeya.Models;

namespace Veeya.Persistence
{
    public interface IPropertyRepository
    {
         Task<Property> GetProperty(int id, bool includeRelated = true);
         void Add(Property property);
         void Remove(Property property);
    }
}