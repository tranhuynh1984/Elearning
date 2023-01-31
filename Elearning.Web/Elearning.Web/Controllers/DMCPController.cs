﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Elearning.Core.Contants;
using Elearning.Core.Contracts;
using Elearning.Core.Contracts.DMCP;
using Elearning.Core.DTO.Request;
using Elearning.Core.DTO.Request.DMCP;
using Elearning.Core.DTO.Request.Users;
using Elearning.Core.DTO.Response.Groups;
using Elearning.Core.DTO.Response.DMCP;
using Elearning.Core.Enum;
using Elearning.Infrastructure.Constants;
using Elearning.Infrastructure.Extensions;
using Elearning.Web.Filters;
using Elearning.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Elearning.Web.Models.Dashboard;
using Elearning.Core.Contracts.NhCP;
using Elearning.Core.DTO.Request.DMPN;
using Elearning.Core.DTO.Response.NhCP;
using Elearning.Core.Contracts.DMDV;
using Elearning.Core.DTO.Response.DMDV;
using System.IO;
using Elearning.Infrastructure.Services;
using Aspose.Cells;
using System.Linq;

namespace Elearning.Web.Controllers
{
    public class DMCPController : BaseController
    {
        private readonly IDMCPRepository _DMCPRepository;
        private readonly INhCPRepository _NhCPRepository;
        private readonly IDMDVRepository _DMDVRepository;
        private readonly ILogger<DMCPController> _logger;
        private readonly IMedAuthenticateConnect _authenticateConnect;
        private readonly IConfiguration _configuration;

        public DMCPController(ILogger<DMCPController> logger, IMedAuthenticateConnect authenticateConnect
            , IConfiguration configuration, IDMCPRepository dMCPRepository
            , INhCPRepository nhCPRepository, IDMDVRepository dMDVRepository)
        {
            //_legalRepository = legalRepository;
            _logger = logger;
            _authenticateConnect = authenticateConnect;
            _configuration = configuration;
            _DMCPRepository = dMCPRepository;
            _NhCPRepository = nhCPRepository;
            _DMDVRepository = dMDVRepository;
        }

        [AuthorizeUser(Module = Functions.DMCPView, Permission = PermissionConstant.VIEW)]
        public async Task<IActionResult> List()
        {
            var searchModel = new DMCPFilterModel();
            //searchModel.Branchs = new SelectList<DMDVSearchResponseData>();
            //searchModel.Categories = new SelectList<NhCPSearchResponseData>();
            List<NhCPSearchResponseData> data = new List<NhCPSearchResponseData>();
            List<DMDVSearchResponseData> data2 = new List<DMDVSearchResponseData>();
            data = await _NhCPRepository.GetCategory().ConfigureAwait(true);
            data.Insert(0, new NhCPSearchResponseData() { MaNhCP = "-1", TenNhCP = "Tất cả", TenNhCPFull = "Tất cả" });
            var categories = new SelectList(data, "MaNhCP", "TenNhCP", "-1");

            data2 = await _DMDVRepository.GetCategory().ConfigureAwait(true);
            data2.Insert(0, new DMDVSearchResponseData() { MaDV = "-1", TenDV = "Tất cả" });
            var branchs = new SelectList(data2, "MaDV", "TenDV", "-1");
            searchModel.Branchs = branchs;
            searchModel.Categories = categories;
            return View(searchModel);
        }

        public async Task<IActionResult> Search(int length, int start, DMCPSearchRequest request)
        {
            DMCPSearchResponse data;
            try
            {
                request.Draw = Request.Query["draw"].ToString().ToInt32();
                request.RequestPage = DepartmentConst.PublicKey;
                data = await _DMCPRepository.Search(start, length, request).ConfigureAwait(true);
            }
            catch (Exception e)
            {
                _logger.Log(LogLevel.Error, e, e.Message);
                return Json(new GroupsSearchResponse
                {
                    Code = (int)HttpStatusCode.NoContent,
                    Draw = request.Draw,
                    Message = "Không tìm thấy dữ liệu yêu cầu!"
                });
            }
            return Json(data);
        }

        public async Task<IActionResult> ExportExcel(DMCPSearchRequest request)
        {
            var data = await _DMCPRepository.SearchAll(request).ConfigureAwait(false);
            var mappingHeader = new Dictionary<string, string>
            {
                //["Stt"] = "STT",
                //["PhapNhanId"] = "Id pháp nhân",
                //["PhapNhanName"] = "Tên pháp nhân",
                //["IsActiveName"] = "Trạng thái",
                //["CompanyName"] = "Tên công ty",
                //["TaxNumber"] = "Mã số thuế",
                //["AddressCompany"] = "Địa chỉ"
                ["Index"] = "STT",
                ["MaCP"] = "Mã dịch vụ",
                ["TenCP"] = "Tên dịch vụ",
                ["DVT"] = "Đơn vị tính",
                ["DG"] = "Đơn giá",
                ["MaNhCP"] = "Nhóm dịch vụ",
                ["IsActiveName"] = "Trạng thái"
            };
            var workbook = ExcelService.ExportExcel(mappingHeader, data.Data.Cast<dynamic>().ToList(), "Danh sách dịch vụ");
            using (var memoryStream = new MemoryStream())
            {
                workbook.Save(memoryStream, new OoxmlSaveOptions(SaveFormat.Xlsx));
                memoryStream.Position = 0;
                byte[] sheetData = memoryStream.ToArray();
                return File(sheetData, Core.Contants.HttpContentMediaTypes.XLSX, "Danh_sach_dich_vu.xlsx");
            }
        }
    }
}