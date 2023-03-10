using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Elearning.Core.Contants;
using Elearning.Core.Contracts;
using Elearning.Core.Contracts.DMDV;
using Elearning.Core.Contracts.DMPN;
using Elearning.Core.DTO.Request;
using Elearning.Core.DTO.Request.DMDV;
using Elearning.Core.DTO.Request.DMPN;
using Elearning.Core.DTO.Request.Users;
using Elearning.Core.DTO.Response.Groups;
using Elearning.Core.DTO.Response.DMDV;
using Elearning.Core.DTO.Response.DMPN;
using Elearning.Core.Enum;
using Elearning.Infrastructure.Constants;
using Elearning.Infrastructure.Extensions;
using Elearning.Web.Filters;
using Elearning.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Elearning.Web.Models.Dashboard;
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
    public class DMDVController : BaseController
    {
        private readonly IDMDVRepository _DMDVRepository;
        private readonly IDMPNRepository _DMPNRepository;
        private readonly ILogger<DMDVController> _logger;
        private readonly IMedAuthenticateConnect _authenticateConnect;
        private readonly IConfiguration _configuration;

        public DMDVController(IDMDVRepository DMDVRepository, IDMPNRepository MPNRepository, ILogger<DMDVController> logger, IMedAuthenticateConnect authenticateConnect, IConfiguration configuration)
        {
            _DMDVRepository = DMDVRepository;
            _DMPNRepository = MPNRepository;
            _logger = logger;
            _authenticateConnect = authenticateConnect;
            _configuration = configuration;
        }

        //[AuthorizeUser(Module = Functions.DMDVView, Permission = PermissionConstant.VIEW)]
        public async Task<IActionResult> List()
        {
            var searchModel = new DMDVFilterModel();
            searchModel.DMPN = new List<SelectListItem>();
            searchModel.DMPN.Add(new SelectListItem("Tất cả","-1"));

            DMPNSearchResponse data;
            data = await _DMPNRepository.SearchAll(new DMPNSearchRequest());

            foreach (var d in data.Data)
            {
                var item = new SelectListItem();
                item.Text = d.PhapNhanId.ToString() + "-" + d.PhapNhanName;
                item.Value = d.PhapNhanId.ToString();

                searchModel.DMPN.Add(item);
            }

            return View(searchModel);
        }

        public async Task<IActionResult> Search(int length, int start, DMDVSearchRequest @base)
        {
            DMDVSearchResponse data;

            @base.Draw = Request.Query["draw"].ToString().ToInt32();
            @base.RequestPage = DepartmentConst.PublicKey;
            data = await _DMDVRepository.Search(start, length, @base);

            return Json(data);
        }

        public async Task<IActionResult> ExportExcel(DMDVSearchRequest @base)
        {
            var data = await _DMDVRepository.SearchAll(@base).ConfigureAwait(false);
            var mappingHeader = new Dictionary<string, string>
            {
                ["Stt"] = "STT",
                ["MaDV"] = "Mã đơn vị",
                ["TenDV"] = "Tên đơn vị",
                ["PhapNhanId"] = "Mã pháp nhân",
                ["PhapNhanName"] = "Tên pháp nhân",
                ["IsActiveName"] = "Trạng thái",
                ["MaSAP"] = "Mã SAP pháp nhân",
                ["MaDVExSap"] = "Mã SAP pháp nhân"
            };
            var workbook = ExcelService.ExportExcel(mappingHeader, data.Data.Cast<dynamic>().ToList(), "Danh sách đơn vị");
            using (var memoryStream = new MemoryStream())
            {
                workbook.Save(memoryStream, new OoxmlSaveOptions(SaveFormat.Xlsx));
                memoryStream.Position = 0;
                byte[] sheetData = memoryStream.ToArray();
                return File(sheetData, HttpContentMediaTypes.XLSX, "Danh_sach_don_vi.xlsx");
            }
        }
    }
}
