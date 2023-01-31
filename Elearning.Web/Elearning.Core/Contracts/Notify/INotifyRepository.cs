using System.Threading.Tasks;

namespace Elearning.Core.Contracts.Notify
{
    public interface INotifyRepository
    {
        Task<bool> AddAsync(Database.Models.Notify add);
    }
}
