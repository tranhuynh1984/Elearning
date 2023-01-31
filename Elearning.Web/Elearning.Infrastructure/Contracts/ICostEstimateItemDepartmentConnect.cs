using EasyCaching.Core.Interceptor;
using Elearning.Core.DTO.Response;
using Elearning.Core.Enum;
using System.Threading.Tasks;
using Elearning.Core.DTO.Response.CostEstimateItem;

namespace Elearning.Infrastructure.Contracts
{
    public interface ICostEstimateItemDepartmentConnect
    {
        [EasyCachingAble(Expiration = CacheContant.EXPIRATION_5m)]
        Task<CostEstimateItemDepartmentResponse[]> GetDataAsync(string endPoint);
    }
}
