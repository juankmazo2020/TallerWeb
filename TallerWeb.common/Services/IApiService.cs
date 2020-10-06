using System.Threading.Tasks;
using TallerWeb.Common.Responses;

namespace TallerWeb.Common.Services
{
    public interface IApiService
    {
        Task<Response> GetListAsync<T>(string urlBase, string servicePrefix, string controller);
    }

}
