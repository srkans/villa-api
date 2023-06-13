using MagicVilla.Utility;
using MagicVilla.Web.Models;
using MagicVilla.Web.Models.DTO;
using MagicVilla.Web.Services.IServices;

namespace MagicVilla.Web.Services
{
    public class AuthService : BaseService, IAuthService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string _villaUrl;

        public AuthService(IHttpClientFactory clientFactory, IConfiguration configuration) :base(clientFactory)
        {
            _clientFactory = clientFactory;
            _villaUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI");
        }

        public async Task<T> LoginAsync<T>(LoginRequestDTO obj)
        {

            return await SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.POST,
                Data = obj,
                Url = _villaUrl + "/api/v1/UsersAuth/login"
            }); 
        }

        public async Task<T> RegisterAsync<T>(RegisterationRequestDTO obj)
        {
            return await SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.POST,
                Data = obj,
                Url = _villaUrl + "/api/v1/UsersAuth/register"
            });
        }
    }
}
