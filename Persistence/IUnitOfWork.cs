using System.Threading.Tasks;

namespace Veeya.Persistence
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}