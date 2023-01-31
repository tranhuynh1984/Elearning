using EasyCaching.Core.Interceptor;
using Elearning.Core.DTO.Response;
using Elearning.Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Elearning.Infrastructure.Contracts
{
    public interface ISupplierConnect
    {
        [EasyCachingAble(Expiration = CacheContant.EXPIRATION_5m)]
        Task<SupplierResponse[]> GetDataAsync(string endPoint);
    }
}
