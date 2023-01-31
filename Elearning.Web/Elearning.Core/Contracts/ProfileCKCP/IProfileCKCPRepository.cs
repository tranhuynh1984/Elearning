using System.Collections.Generic;
using System.Threading.Tasks;
using EasyCaching.Core.Interceptor;
using Elearning.Core.DTO.Request.ProfileCKCP;
using Elearning.Core.DTO.Response.ProfileCKCP;
using Elearning.Core.Enum;
using Elearning.Database.Models;

namespace Elearning.Core.Contracts.ProfileCKCP
{
    public interface IProfileCKCPRepository
    {
        Task<ProfileCKCPSearchResponse> Search(string profileCKMa ="", string Keywords = "");
        Task<ProfileCKCPSearchResponseData> GetById(string profileCKMa, string CPMa);
        Task<ProfileCKCPCreateResponse> Create(ProfileCKCPCreateRequest request);
        Task<ProfileCKCPCreateResponse> Remove(ProfileCKCPCreateRequest request);
    }
}
