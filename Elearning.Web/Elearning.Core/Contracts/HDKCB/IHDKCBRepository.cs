using System.Collections.Generic;
using System.Threading.Tasks;
using Elearning.Core.DTO.Request.HDKCB;
using Elearning.Core.DTO.Response.HDKCB;

namespace Elearning.Core.Contracts.HDKCB
{
    public interface IHDKCBRepository
    {
        Task<HDKCBSearchResponse> Search(int skip, int length, HDKCBSearchRequest request);
        Task<HDKCBSearchResponse> SearchAll(HDKCBSearchRequest request);
        Task<HDKCBDetailResponse> GetByIdAsync(int id);
        Task<DetailDVSearchResponse> GetByHDKCKService(int skip, int length, string keyword, int? draw, int idhd);
    }
}
