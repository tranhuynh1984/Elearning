using System.Collections.Generic;
using System.Threading.Tasks;
using EasyCaching.Core.Interceptor;
using Elearning.Core.DTO.Request.ProfileCK;
using Elearning.Core.DTO.Response.ProfileCK;
using Elearning.Core.Enum;
using Elearning.Database.Models;

namespace Elearning.Core.Contracts.ProfileCK
{
    public interface IProfileCKRepository
    {
        Task<ProfileCKSearchResponse> Search(int skip, int length, ProfileCKSearchRequest request);
        Task<ProfileCKSearchResponse> SearchAll(ProfileCKSearchRequest request);
        Task<ProfileCKSearchResponseData> GetById(string profileCKMa);
        Task<ProfileCKCreateResponse> Create(ProfileCKCreateRequest request);
        Task<ProfileCKCreateResponse> Remove(ProfileCKCreateRequest request);
    }
}
