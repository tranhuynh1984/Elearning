using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Elearning.Core.Contracts.CostEstimate;
using Elearning.Core.DTO.Request.CostEstimate;
using Elearning.Core.DTO.Response.CostEstimate;
using Elearning.Core.Enum;
using Elearning.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Elearning.Core.Data.CostEstimateItem
{
    public class CostEstimateLogRepository : ICostEstimateLogRepository
    {
        private readonly ILogger<CostEstimateLogRepository> _logger;
        private readonly Context _ctx;

        public CostEstimateLogRepository(ILogger<CostEstimateLogRepository> logger, Context ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }
        public async Task<IList<CostEstimateLogResponse>> ViewHistories(CostEstimateLogRequest request)
        {
            try
            {
                // loại bỏ trạng thái tạo mới / chỉnh sửa
                var query = await _ctx.CostEstimateLogs.Where(x => x.CostEstimateId == request.RawId && x.FromStatus != (int)GlobalEnums.StatusDefaultEnum.Temporary)
                    .OrderByDescending(x => x.CreatedDate).ToListAsync();
                var data = query.Select(x => new CostEstimateLogResponse
                {
                    UserName = x.UserName,
                    PositionName = x.PositionName,
                    Reason = x.Reason,
                    TimeChange = x.CreatedDate.ToString("dd/MM/yyyy HH:mm"),
                    Status = x.ToStatusName
                }).ToList();
                return data;

            }
            catch (Exception e)
            {
                _logger.Log(LogLevel.Error, e, e.Message, request);
                Log.Error(e, e.Message);

                return new List<CostEstimateLogResponse>();
            }
        }
    }
}
