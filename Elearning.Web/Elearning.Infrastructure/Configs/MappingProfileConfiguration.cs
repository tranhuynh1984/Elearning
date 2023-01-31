using AutoMapper;
using Elearning.Core.DTO.Entities;
using Elearning.Core.DTO.Request;
using Elearning.Core.DTO.Request.CostEstimate;
using Elearning.Core.DTO.Request.CostEstimateItem;
using Elearning.Core.DTO.Response;
using Elearning.Core.DTO.Response.Actually;
using Elearning.Core.DTO.Response.CashFollow;
using Elearning.Core.DTO.Response.CostEstimate;
using Elearning.Core.DTO.Response.CostEstimateItem;
using Elearning.Core.DTO.Response.CostStatus;
using Elearning.Core.DTO.Response.Department;
using Elearning.Core.DTO.Response.Groups;
using Elearning.Core.DTO.Response.InvestmentPlan;
using Elearning.Core.DTO.Response.ProfitPlan;
using Elearning.Core.DTO.Response.RevenuePlan;
using Elearning.Core.DTO.Response.Unit;
using Elearning.Core.DTO.Response.Users;
using Elearning.Database.Models;
using Elearning.Core.DTO.Response.DMPN;
using Elearning.Core.DTO.Response.DMDV;
using Elearning.Core.DTO.Response.DMHuyen;
using Elearning.Core.DTO.Response.DM;
using Elearning.Core.DTO.Response.HDKCB;
using Elearning.Core.DTO.Response.DMCP;
using Elearning.Core.DTO.Response.DMBS_ChuyenKhoa;
using Elearning.Core.DTO.Response.LoaiDeXuat;
using Elearning.Core.DTO.Response.DMCTV;
using Elearning.Core.DTO.Response.TBL_CTVGROUP;
using Elearning.Core.DTO.Response.TBL_CTVGROUPSUB;
using Elearning.Core.DTO.Response.TBL_CTVGROUPSUB1_DETAIL;
using Elearning.Core.DTO.Response.TBL_CTVGROUPSUB2_DETAIL;
using Elearning.Core.DTO.Response.ProfileCK;
using Elearning.Core.DTO.Response.Relationship;
using Elearning.Core.DTO.Response.ProfileCKCP;
using Elearning.Core.DTO.Response.DeXuat;
using Elearning.Core.DTO.Response.DeXuatChiTiet;
using Elearning.Database.Models.Phase2;
using Elearning.Core.DTO.Response.ProcessStep;
using Elearning.Core.DTO.Response.Process;
using Elearning.Core.DTO.Response.DeXuatGhiChu;
using Elearning.Core.DTO.Response.DeXuatKhoaMaCTV;
using Elearning.Core.DTO.Response.DeXuatLuanChuyenMa;

namespace Elearning.Infrastructure.Configs
{
    public class MappingProfileConfiguration : Profile
    {
        public MappingProfileConfiguration()
        {
            CreateMap<CostEstimateItemCreateRequest, CostEstimateItem>();
            CreateMap<CostEstimateItem, CostEstimateItemCreateRequest>();
            CreateMap<ActuallySpentItem, ActuallySpentItemResponse>();
            CreateMap<CostEstimateUpdate, Database.Models.CostEstimate>();
            CreateMap<ActuallySpentItemResponse, ActuallySpentItem>();
            CreateMap<ActuallySpent, SearchActuallySpentData>();
            CreateMap<CostEstimateItemFromExcel, CostEstimateItem>();
            CreateMap<Database.Models.CostEstimate, SearchCostEstimateResponseData>();
            CreateMap<SCTView, SctData>();
            CreateMap<ExportCostEstimateModel, CostEstimateUpdate>();

            CreateMap<Departments, DepartmentSearchResponseData>();
            CreateMap<Groups, GroupsSearchResponseData>();
            CreateMap<CostStatuses, CostStatusSearchResponseData>();
            CreateMap<Units, UnitSearchResponseData>();
            CreateMap<Users, UsersSearchResponseData>();
            CreateMap<UserSync, Users>();
            CreateMap<InvestmentPlan, SearchInvestmentPlanResponseData>();
            CreateMap<RevenuePlan, SearchRevenuePlanResponseData>();

            CreateMap<ProfitPlan, SearchProfitPlanResponseData>();
            CreateMap<ProfitPlanAggregatesExcel, ProfitPlanAggregates>();
            CreateMap<ProfitPlanDetailExcel, ProfitPlanDetails>();

            CreateMap<CashFollowAggregateExcel, CashFollowAggregates>();
            CreateMap<CashFollowAggregates, CashFollowAggregateExcel>();

            CreateMap<CashFollowItemExcel, CashFollowItem>();
            CreateMap<CashFollowItem, CashFollowItemExcel>();
            CreateMap<CostEstimateItem, CostEstimateItemSearchResponseData>();

            CreateMap<DMPN, DMPNSearchResponseData>();
            CreateMap<DMDV, DMDVSearchResponseData>();
            CreateMap<DMHuyen, DMHuyenSearchResponseData>();
            CreateMap<DM, DMSearchResponseData>();
            CreateMap<HDKCB, HDKCBSearchResponseData>();
            CreateMap<DMCP, DMCPSearchResponseData>();
            CreateMap<DMCPSearchResponseData, DMCPSearchResponseData>();
            CreateMap<DMBS_ChuyenKhoa, DMBS_ChuyenKhoaSearchResponseData>();
            CreateMap<LoaiDeXuat, LoaiDeXuatSearchResponseData>();
            //CreateMap<HDCTV, DMCTVSearchResponseData>();

            CreateMap<TBL_CTVGROUP, TBL_CTVGROUPSearchResponseData>();
            CreateMap<TBL_CTVGROUPSUB, TBL_CTVGROUPSUBSearchResponseData>();
            CreateMap<TBL_CTVGROUPSUB1_DETAIL, TBL_CTVGROUPSUB1_DETAILSearchResponseData>();
            CreateMap<TBL_CTVGROUPSUB2_DETAIL, TBL_CTVGROUPSUB2_DETAILSearchResponseData>();

            CreateMap<ProfileCK, ProfileCKSearchResponseData>();
            CreateMap<ProfileCKCP, ProfileCKCPSearchResponseData>();
            CreateMap<Relationship, RelationshipSearchResponseData>();
            CreateMap<DeXuat, DeXuatSearchResponseData>();
            CreateMap<DeXuatChiTiet, DeXuatChiTietSearchResponseData>();
            CreateMap<DeXuatKhoaMaCTV, DeXuatKhoaMaCTVSearchResponseData>();
            CreateMap<DeXuatLuanChuyenMa, DeXuatLuanChuyenMaSearchResponseData>();
            CreateMap<DeXuatGhiChu, DeXuatGhiChuSearchResponseData>();
            CreateMap<Process, ProcessSearchResponseData>();
            CreateMap<ProcessStep, ProcessStepSearchResponseData>();
            CreateMap<DMCTV, DMCTVSearchResponseData>();
        }
    }
}