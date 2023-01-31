using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Elearning.Core.Contracts;
using Elearning.Core.Contracts.Actions;
using Elearning.Core.Contracts.DeXuat;
using Elearning.Core.Contracts.DeXuatGhiChu;
using Elearning.Core.Contracts.GiaKCB;
using Elearning.Core.DTO.Request.DeXuat;
using Elearning.Core.DTO.Request.DeXuatGhiChu;
using Elearning.Core.DTO.Response.DeXuat;
using Elearning.Core.Enum;
using Elearning.Database;
using Elearning.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Serilog;

namespace Elearning.Core.Data.GiaKCB
{
    public class GiaKCBRepository : IGiaKCBRepository
    {
        private readonly Context _context;
        private readonly IMapper _mapper;
        private readonly ILogger<GiaKCBRepository> _logger;

        public GiaKCBRepository(Context context, IMapper mapper, ILogger<GiaKCBRepository> logger)
        {
            this._context = context;
            _mapper = mapper;
            _logger = logger;
        }
    }
}
