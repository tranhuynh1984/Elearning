using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Elearning.Core.Contants;
using Elearning.Core.Contracts;
using Elearning.Core.Contracts.Actions;
using Elearning.Core.Contracts.ProcessStep;
using Elearning.Core.DTO.Request.ProcessStep;
using Elearning.Core.DTO.Response.ProcessStep;
using Elearning.Core.Enum;
using Elearning.Database;
using Elearning.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Serilog;

namespace Elearning.Core.Data.ProcessStep
{
    public class ProcessStepRepository : IProcessStepRepository
    {
        private readonly Context _context;
        private readonly IMapper _mapper;
        private readonly ILogger<ProcessStepRepository> _logger;
        private readonly IActionLogsRepository _actionLogsRepository;

        public ProcessStepRepository(Context context, IMapper mapper, ILogger<ProcessStepRepository> logger, IActionLogsRepository actionLogsRepository)
        {
            this._context = context;
            _mapper = mapper;
            _logger = logger;
            _actionLogsRepository = actionLogsRepository;
        }

        public async Task<ProcessStepSearchResponse> Search()
        {
            var response = new ProcessStepSearchResponse();
           
            var query = _context.ProcessStep.AsNoTracking();
            var data = await query.OrderBy(x => x.ProcessId).ToListAsync();

            response.RecordsFiltered = data.Count;
            response.RecordsTotal = data.Count;
            var dataResponse = new List<ProcessStepSearchResponseData>();

            foreach (var d in data)
            {
                var dMap = _mapper.Map<ProcessStepSearchResponseData>(d);
                dataResponse.Add(dMap);
            }
            response.Data = dataResponse;
            response.Code = (int)GlobalEnums.ResponseCodeEnum.Success;

            return response;
        }
        public async Task<ProcessStepSearchResponse> SearchStep(int processId, string dexuat = "")
        {
            var response = new ProcessStepSearchResponse();

            var query = _context.ProcessStep.AsNoTracking();
            query = query.Where(x => x.ProcessId == processId);
            var data = await query.OrderBy(x => x.ProcessId).ToListAsync();

            response.RecordsFiltered = data.Count;
            response.RecordsTotal = data.Count;
            var dataResponse = new List<ProcessStepSearchResponseData>();

            foreach (var d in data)
            {   
                var dMap = _mapper.Map<ProcessStepSearchResponseData>(d);
                var _ProcessRole = _context.ProcessRole.Where(x => x.IDRole == dMap.OrderStep).FirstOrDefault();
                dMap.ProcessRoleName = _ProcessRole.Name;
                dMap.ProcessRoleId = _ProcessRole.IDRole;

                if (dataResponse.Count == 0)
                {
                    string firstNote = "";
                    if (data.Count > 0)
                        firstNote = _context.DeXuat.Where(x => x.DeXuatCode == dexuat).First().Note;
                    dMap.Note = firstNote;
                }
                else
                {
                    var _deXuatChiTiet = _context.DeXuatGhiChu.Where(x => x.DeXuatCode == dexuat && x.ProcessStepId == dMap.ProcessRoleId).FirstOrDefault();
                    dMap.Note = _deXuatChiTiet == null? "" : _deXuatChiTiet.Note;
                }

                dataResponse.Add(dMap);
            }
            response.Data = dataResponse;
            response.Code = (int)GlobalEnums.ResponseCodeEnum.Success;

            return response;
        }

        public async Task<List<ProcessStepDetailInfo>> GetProcessStepDetail(int processId)
        {
            var query = _context.ProcessStep.AsNoTracking();
            return await query.Where(x => x.ProcessId == processId)
                .LeftJoin(_context.ProcessRole, ps => ps.OrderStep, pr => pr.IDRole, (ps, pr) => new ProcessStepDetailInfo
                {
                    StepId = ps.StepId,
                    StepName = ps.StepName,
                    ProcessId = ps.ProcessId,
                    OrderStep = ps.OrderStep,
                    IsLastStep = ps.IsLastStep,
                    GroupId = ps.GroupId,
                    ProcessRoleId = ps.ProcessRoleId,
                    ProcessRoleName = pr.Name,
                })
                .OrderBy(x => x.OrderStep)
                .ToListAsync().ConfigureAwait(false);
        }
    }
}
