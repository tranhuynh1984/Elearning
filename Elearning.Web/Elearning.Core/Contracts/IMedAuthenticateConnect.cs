using Elearning.Core.DTO.Request;
using Elearning.Core.DTO.Response;
using Elearning.Database.Models;
using System.Threading.Tasks;
using Elearning.Core.DTO.Response.Users;

namespace Elearning.Core.Contracts
{
    public interface IMedAuthenticateConnect
    {
        Task<string> GetAccessTokenAsync(string endPoint, MedAccesstokenRequest request);
        Task<MedApiResponse<UserSync>> LoginAsync(string accesstoken, string user, string pass, string endPoint);
        Task<MedApiResponse<Units>> GetUnitsAsync(string endPoint, string accesstoken);
        Task<MedApiResponse<UserSync>> GetUsersAsync(string endPoint, string accesstoken, int page, int size);
        Task<MedApiResponse<Users>> GetUserByUnitCodeAsync(string code, string accesstoken, string endPoint);
        Task<MedTelegramBotResponse> SendMessage(string body, string accesstoken, string endPoint);
    }
}
