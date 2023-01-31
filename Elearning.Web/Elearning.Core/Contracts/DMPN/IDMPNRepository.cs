using System.Threading.Tasks;
using Elearning.Core.DTO.Request.DMPN;
using Elearning.Core.DTO.Response.DMPN;

namespace Elearning.Core.Contracts.DMPN
{
    public interface IDMPNRepository
    {
        Task<DMPNSearchResponse> Search(int skip, int length, DMPNSearchRequest request);
        Task<DMPNSearchResponse> SearchAll(DMPNSearchRequest request);
    }
}
