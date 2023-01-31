using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Elearning.Core.Contracts;
using Elearning.Core.Contracts.HDCTV;
using Elearning.Core.DTO.Request.HDCTV;
using Elearning.Core.DTO.Response.HDCTV;
using Elearning.Core.Enum;
using Elearning.Database;
using Elearning.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Elearning.Core.Data.HDCTV
{
    public class HDCTVRepository : IHDCTVRepository
    {
        private readonly Context _context;
        private readonly IMapper _mapper;
        private readonly ILogger<HDCTVRepository> _logger;

        public HDCTVRepository(Context context, IMapper mapper, ILogger<HDCTVRepository> logger)
        {
            this._context = context;
            _mapper = mapper;
            _logger = logger;
        }
        
    }
}
