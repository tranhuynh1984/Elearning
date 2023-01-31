using System.Collections.Generic;
using System.Threading.Tasks;
using EasyCaching.Core.Interceptor;
using Elearning.Core.DTO.Request.DeXuat;
using Elearning.Core.DTO.Response.DeXuat;
using Elearning.Core.Enum;
using Elearning.Database.Models;

namespace Elearning.Core.Contracts.DeXuat
{
    public interface IDeXuatRepository
    {
        Task<DeXuatSearchResponse> Search(int skip, int length, DeXuatSearchRequest request);
        Task<DeXuatSearchResponse> SearchAll(DeXuatSearchRequest request);
        Task<DeXuatSearchResponseData> GetByCode(string dexuatcode);

        Task<DeXuatCreateResponse> Create(DeXuatCreateRequest request);
        Task<DeXuatCreateResponse> PushDeXuat(DeXuatCreateRequest request);
        Task<DeXuatCreateResponse> RejectDeXuat(DeXuatCreateRequest request);
        Task<int> ChoDuyet(int IDRole);
        Task<int> DaDuyet(int IDRole);
        Task<int> HoanThanh(int IDRole);
        Task<int> QuaHan(int IDRole);
        Task<DeXuatCreateResponse> Remove(DeXuatCreateRequest request);

    }
}
