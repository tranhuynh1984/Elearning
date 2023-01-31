using System.Collections.Generic;
using System.Threading.Tasks;
using EasyCaching.Core.Interceptor;
using Elearning.Core.DTO.Request.DeXuatLuanChuyenMa;
using Elearning.Core.DTO.Response.DeXuatLuanChuyenMa;
using Elearning.Core.Enum;
using Elearning.Database.Models;

namespace Elearning.Core.Contracts.DeXuatLuanChuyenMa
{
    public interface IDeXuatLuanChuyenMaRepository
    {
        Task<DeXuatLuanChuyenMaSearchResponse> Search(DeXuatLuanChuyenMaSearchRequest request);
        Task<DeXuatLuanChuyenMaCreateResponse> Create(DeXuatLuanChuyenMaCreateRequest request);
        Task<DeXuatLuanChuyenMaCreateResponse> Remove(DeXuatLuanChuyenMaCreateRequest request);
    }
}
