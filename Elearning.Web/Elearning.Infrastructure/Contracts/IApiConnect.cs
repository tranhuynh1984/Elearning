using System.Threading.Tasks;

namespace Elearning.Infrastructure.Contracts
{
    public interface IApiConnect
	{
		Task<TResponse> PostDataAsync<TResponse, TRequest>(string endPoint, TRequest request);
		Task<TResponse> GetDataAsync<TResponse>(string endPoint);
	}
}
