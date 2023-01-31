using System.Threading.Tasks;
using Elearning.Database.Models;

namespace Elearning.Core.Contracts.PdfLogs
{
    public interface IPdfLogsRepository
    {
        Task<bool> CreateAsync(FilePdfCreateLogs create);
        Task<int> CounterDay(int unit, string type);
    }
}
