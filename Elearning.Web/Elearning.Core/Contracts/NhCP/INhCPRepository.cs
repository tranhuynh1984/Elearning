using Elearning.Core.DTO.Response.NhCP;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Elearning.Core.Contracts.NhCP
{
    public interface INhCPRepository
    {
        Task<NhCPSearchResponse> GetAll();

        Task<List<NhCPSearchResponseData>> GetCategory();
    }
}