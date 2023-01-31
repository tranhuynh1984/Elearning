using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Elearning.Core.Contants;
using Elearning.Core.Contracts;
using Elearning.Core.Contracts.ProcessStep;
using Elearning.Core.DTO.Request;
using Elearning.Core.DTO.Request.ProcessStep;
using Elearning.Core.DTO.Request.Users;
using Elearning.Core.DTO.Response.Groups;
using Elearning.Core.DTO.Response.ProcessStep;
using Elearning.Core.Enum;
using Elearning.Infrastructure.Constants;
using Elearning.Infrastructure.Extensions;
using Elearning.Web.Filters;
using Elearning.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using Elearning.Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;
using ContentDispositionHeaderValue = System.Net.Http.Headers.ContentDispositionHeaderValue;
using HttpContentMediaTypes = Elearning.Core.Contants.HttpContentMediaTypes;
using MediaTypeHeaderValue = System.Net.Http.Headers.MediaTypeHeaderValue;
using System.IO;
using System.Linq;
using Aspose.Cells;
using Elearning.Core.Contracts.DeXuat;
using Elearning.Web.Models.Dashboard;

namespace Elearning.Web.Controllers
{
    public class StepController : BaseController
    {
        private readonly ILogger<LoaiDeXuatController> _logger;
        private readonly IMedAuthenticateConnect _authenticateConnect;
        private readonly IConfiguration _configuration;
        private readonly IDeXuatRepository _deXuatRepository;
        private readonly IProcessStepRepository _processStepRepository;

        public StepController(IDeXuatRepository deXuatRepository, IProcessStepRepository processStepRepository, ILogger<LoaiDeXuatController> logger, IMedAuthenticateConnect authenticateConnect, IConfiguration configuration)
        {
            _logger = logger;
            _authenticateConnect = authenticateConnect;
            _configuration = configuration;
            _deXuatRepository = deXuatRepository;
            _processStepRepository = processStepRepository;
        }

        public async Task<IActionResult> List(string Dexuat = "")
        {
            DeXuatStepFilterModel model = new DeXuatStepFilterModel();
            model.DeXuatCode = Dexuat;
            model.IDRole = GetProcessRoleSessionModel();
            model.DeXuatSearchResponseData = await _deXuatRepository.GetByCode(Dexuat);
            model.ProcessStepSearchResponseData = await _processStepRepository.SearchStep(model.DeXuatSearchResponseData.ProcessId, Dexuat);

            if (model.DeXuatSearchResponseData.IsDone == 1 )
                model.Title = model.DeXuatCode + " - " + model.DeXuatSearchResponseData.DeXuatName + "|" + "Hoàn thành";
            else if (model.DeXuatSearchResponseData.ThoiGianKhoa?.Date < DateTime.Now.Date && model.DeXuatSearchResponseData.ProcessStepId < model.DeXuatSearchResponseData.ProcessId)
                model.Title = model.DeXuatCode + " - " + model.DeXuatSearchResponseData.DeXuatName + "|" + "Quá hạn";
            else if (model.DeXuatSearchResponseData.ProcessStepId > model.DeXuatSearchResponseData.ProcessId || (model.DeXuatSearchResponseData.IsDone == 1 && model.DeXuatSearchResponseData.ProcessStepId == model.DeXuatSearchResponseData.ProcessId))
                model.Title = model.DeXuatCode + " - " + model.DeXuatSearchResponseData.DeXuatName + "|" + "Đã duyệt";
            else
                model.Title = model.DeXuatCode + " - " + model.DeXuatSearchResponseData.DeXuatName + "|" + "Chờ duyệt";

            return View(model);
        }
    }
}
