using System.Collections.Generic;
using System.Threading.Tasks;
using EasyCaching.Core.Interceptor;
using Elearning.Core.DTO.Request.ProcessStep;
using Elearning.Core.DTO.Response.ProcessStep;
using Elearning.Core.Enum;
using Elearning.Database.Models;

namespace Elearning.Core.Contracts.ProcessStep
{
    public interface IProcessStepRepository
    {
        Task<ProcessStepSearchResponse> Search();
        Task<ProcessStepSearchResponse> SearchStep(int processId, string dexuat ="");
        Task<List<ProcessStepDetailInfo>> GetProcessStepDetail(int processId);
    }
}
