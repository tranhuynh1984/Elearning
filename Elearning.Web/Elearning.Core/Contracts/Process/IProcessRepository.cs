using System.Collections.Generic;
using System.Threading.Tasks;
using EasyCaching.Core.Interceptor;
using Elearning.Core.DTO.Request.Process;
using Elearning.Core.DTO.Response.Process;
using Elearning.Core.Enum;
using Elearning.Database.Models;

namespace Elearning.Core.Contracts.Process
{
    public interface IProcessRepository
    {
        Task<ProcessSearchResponse> Search();
    }
}
