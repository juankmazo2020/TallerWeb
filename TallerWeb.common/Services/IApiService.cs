using System.IO;
using System.Threading.Tasks;
using TallerWeb.Common.Models;
using TallerWeb.Common.Responses;

namespace TallerWeb.Common.Services
{
    public interface IApiService
    {
        Task<Response> GetListAsync<T>(string urlBase, string servicePrefix, string controller);

        Task<RandomUsers> GetRandomUser(string urlBase, string servicePrefix);

        Task<Stream> GetPictureAsync(string urlBase, string servicePrefix);

    }

}
