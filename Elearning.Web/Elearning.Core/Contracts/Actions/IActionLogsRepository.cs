using System.Threading.Tasks;
using Elearning.Database.Models;

namespace Elearning.Core.Contracts.Actions
{
    public interface IActionLogsRepository
    {
        Task AddLogAsync(ActionLogs item);
    }
}
