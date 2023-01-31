using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Elearning.Core.Contracts;
using Elearning.Core.Contracts.Actions;
using Elearning.Core.Contracts.Process;
using Elearning.Core.DTO.Request.Process;
using Elearning.Core.DTO.Response.Process;
using Elearning.Core.Enum;
using Elearning.Database;
using Elearning.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Serilog;

namespace Elearning.Core.Data.Process
{
    public class ProcessRepository : IProcessRepository
    {
        private readonly Context _context;
        private readonly IMapper _mapper;
        private readonly ILogger<ProcessRepository> _logger;
        private readonly IActionLogsRepository _actionLogsRepository;

        public ProcessRepository(Context context, IMapper mapper, ILogger<ProcessRepository> logger, IActionLogsRepository actionLogsRepository)
        {
            this._context = context;
            _mapper = mapper;
            _logger = logger;
            _actionLogsRepository = actionLogsRepository;
        }

        public async Task<ProcessSearchResponse> Search()
        {
            var response = new ProcessSearchResponse ();
           
            var query = _context.Process.AsNoTracking();
            var data = await query.OrderBy(x => x.ProcessId).ToListAsync();

            response.RecordsFiltered = data.Count;
            response.RecordsTotal = data.Count;
            var dataResponse = new List<ProcessSearchResponseData>();

            foreach (var d in data)
            {
                var dMap = _mapper.Map<ProcessSearchResponseData>(d);
                dataResponse.Add(dMap);
            }
            response.Data = dataResponse;
            response.Code = (int)GlobalEnums.ResponseCodeEnum.Success;

            return response;
        }

        
    }
}
