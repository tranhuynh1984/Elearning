using System.Collections.Generic;
using System.Threading.Tasks;
using EasyCaching.Core.Interceptor;
using Elearning.Core.DTO.Request.DeXuatChiTiet;
using Elearning.Core.DTO.Response.DeXuatChiTiet;
using Elearning.Core.Enum;
using Elearning.Database.Models;

namespace Elearning.Core.Contracts.DeXuatChiTiet
{
    public interface IDeXuatChiTietRepository
    {
        Task<DeXuatChiTietSearchResponse> Search(DeXuatChiTietSearchRequest request);
        Task<DeXuatChiTietCreateResponse> Create(DeXuatChiTietCreateRequest request);
        Task<DeXuatChiTietCreateResponse> Remove(DeXuatChiTietCreateRequest request);
    }
}
