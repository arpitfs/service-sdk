using Refit;
using ServiceKit.Contracts;
using System.Threading.Tasks;

namespace ServiceKit.Sdk
{
    public interface IServiceApi
    {
        [Get("api/Service")]
        Task<ApiResponse<ServiceResponse>> GetService();
    }
}
