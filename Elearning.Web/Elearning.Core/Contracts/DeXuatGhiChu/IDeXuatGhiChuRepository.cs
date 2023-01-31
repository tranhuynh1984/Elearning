using System.Collections.Generic;
using System.Threading.Tasks;
using Elearning.Core.DTO.Request.DeXuatGhiChu;
using Elearning.Core.DTO.Response.DeXuatGhiChu;

namespace Elearning.Core.Contracts.DeXuatGhiChu
{
    public interface IDeXuatGhiChuRepository
    {
        Task<DeXuatGhiChuSearchResponse> Search(DeXuatGhiChuSearchRequest request);
        Task<DeXuatGhiChuCreateResponse> Create(DeXuatGhiChuCreateRequest request);
        Task<List<Database.Models.DeXuatGhiChu>> FindAllByCode(string code);
    }
}
