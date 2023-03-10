using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Elearning.Core.Contants;
using Elearning.Core.Contracts;
using Elearning.Core.Contracts.DM;
using Elearning.Core.DTO.Request;
using Elearning.Core.DTO.Request.DM;
using Elearning.Core.DTO.Request.Users;
using Elearning.Core.DTO.Response.Groups;
using Elearning.Core.DTO.Response.DM;
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

namespace Elearning.Web.Controllers
{
    public class DMCKDoiTuongController : BaseController
    {
        private readonly IDMRepository _DMRepository;
        private readonly ILogger<DMTinhController> _logger;
        private readonly IMedAuthenticateConnect _authenticateConnect;
        private readonly IConfiguration _configuration;

        public DMCKDoiTuongController(IDMRepository DMRepository, ILogger<DMTinhController> logger, IMedAuthenticateConnect authenticateConnect, IConfiguration configuration)
        {
            _DMRepository = DMRepository;
            _logger = logger;
            _authenticateConnect = authenticateConnect;
            _configuration = configuration;
        }

        public IActionResult List()
        {
            return View();
        }

        public async Task<IActionResult> Search(int length, int start, DMSearchRequest @base)
        {
            DMSearchResponse data;
   
            @base.Draw = Request.Query["draw"].ToString().ToInt32();
            @base.RequestPage = DepartmentConst.PublicKey;
            //Danh mục ck doi tuong	82
            @base.IdTree = 82;
            data = await _DMRepository.Search(start, length, @base);

            return Json(data);
        }

        public async Task<IActionResult> ExportExcel(DMSearchRequest @base)
        {
            //Danh mục ck doi tuong	82
            @base.IdTree = 82;
            var data = await _DMRepository.SearchAll(@base).ConfigureAwait(false);
            var mappingHeader = new Dictionary<string, string>
            {
                ["Index"] = "STT",
                ["MaDM"] = "Mã CK đối tượng",
                ["TenDM"] = "Tên CK đối tượng",
                ["IsActiveName"] = "Trạng thái",
                ["Stt"] = "Thứ tự",
                ["Createby"] = "Người tạo",
                ["CreatedateString"] = "Thời gian tạo",
                ["Updateby"] = "Người sửa",
                ["UpdatedateString"] = "Thời gian sửa"
            };
            var workbook = ExcelService.ExportExcel(mappingHeader, data.Data.Cast<dynamic>().ToList(), "Danh sách CK đối tượng");
            var memoryStream = new MemoryStream();
            workbook.Save(memoryStream, new OoxmlSaveOptions(SaveFormat.Xlsx));
            memoryStream.Position = 0;
            byte[] sheetData = memoryStream.ToArray();
            return File(sheetData, HttpContentMediaTypes.XLSX, "Danh_sach_CK_doi_tuong.xlsx");
        }
        public async Task<IActionResult> Create(string record = default, string viewMode = default)
        {
            ViewBag.ViewMode = viewMode;
            DMSearchResponseData model = new DMSearchResponseData();
            if (!string.IsNullOrEmpty(record))
            {
                model = await _DMRepository.GetById(82, record);
            }
            else
            {
                model.MaxStt = await _DMRepository.GetMaxStt(82);
                model.IsActive = 1;
            }
            return PartialView(model);
        }

        public async Task<IActionResult> OnCreate(DMCreateRequest request)
        {
            request.RequestPage = DepartmentConst.PublicKey;
            request.Creator = GetUserId();
            request.CreatorName = GetUserSyncId();
            request.IdTree = 82;
            var response = await _DMRepository.Create(request);

            return Json(response);
        }
        public async Task<IActionResult> OnRemove(DMCreateRequest request)
        {
            request.RequestPage = DepartmentConst.PublicKey;
            request.IdTree = 82;
            var response = await _DMRepository.Remove(request);

            return Json(response);
        }
    }
}
