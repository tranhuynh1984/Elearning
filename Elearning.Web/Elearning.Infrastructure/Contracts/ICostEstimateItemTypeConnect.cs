using EasyCaching.Core.Interceptor;
using Elearning.Core.DTO.Response;
using Elearning.Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Elearning.Core.DTO.Response.CostEstimateItem;

namespace Elearning.Infrastructure.Contracts
{
    public interface ICostEstimateItemTypeConnect
    {
        [EasyCachingAble(Expiration = CacheContant.EXPIRATION_5m)]
        Task<IList<CostEstimateItemTypeResponse>> GetDataAsync(string endPoint);
    }
}
