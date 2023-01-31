using System.Collections.Generic;
using System.Threading.Tasks;
using EasyCaching.Core.Interceptor;
using Elearning.Core.DTO.Request.DeXuatKhoaMaCTV;
using Elearning.Core.DTO.Response.DeXuatKhoaMaCTV;
using Elearning.Core.Enum;
using Elearning.Database.Models;

namespace Elearning.Core.Contracts.DeXuatKhoaMaCTV
{
    public interface IDeXuatKhoaMaCTVRepository
    {
        Task<DeXuatKhoaMaCTVSearchResponse> Search(DeXuatKhoaMaCTVSearchRequest request);
        Task<DeXuatKhoaMaCTVCreateResponse> Create(DeXuatKhoaMaCTVCreateRequest request);
        Task<DeXuatKhoaMaCTVCreateResponse> Remove(DeXuatKhoaMaCTVCreateRequest request);
    }
}
