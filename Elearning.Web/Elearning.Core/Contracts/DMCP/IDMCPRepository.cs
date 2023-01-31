using System.Collections.Generic;
using System.Threading.Tasks;
using EasyCaching.Core.Interceptor;
using Elearning.Core.DTO.Request.DMCP;
using Elearning.Core.DTO.Response.DMCP;
using Elearning.Core.Enum;
using Elearning.Database.Models;

namespace Elearning.Core.Contracts.DMCP
{
    public interface IDMCPRepository
    {
        //[EasyCachingAble(Expiration = CacheContant.EXPIRATION_10m, CacheKeyPrefix = CacheContant.PrefixUnitCache)]

        //Task<Legal> GetByIdAsync(int id);
        //[EasyCachingAble(Expiration = CacheContant.EXPIRATION_10m, CacheKeyPrefix = CacheContant.PrefixUnitCache)]

        //Task<Legal> GetByCodeAsync(string offCodes);

        //Task<IList<Legal>> GetAllAsync(string name, int offset, int limit);

        //[EasyCachingAble(Expiration = CacheContant.EXPIRATION_10m, CacheKeyPrefix = CacheContant.PrefixUnitCache)]
        //Task<bool> AddRangeAsync(IList<Units> lst);

        Task<DMCPSearchResponse> Search(int skip, int length, DMCPSearchRequest request);

        Task<DMCPSearchResponse> SearchAll(DMCPSearchRequest request);

        //[EasyCachingAble(Expiration = CacheContant.EXPIRATION_10m, CacheKeyPrefix = CacheContant.PrefixUnitCache)]

        //Task<string> GetUnitType(string code);
    }
}