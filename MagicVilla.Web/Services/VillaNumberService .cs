using MagicVilla.Web.Models.DTO;
using MagicVilla.Web.Services.IServices;
using MagicVilla.Web.Models;
using MagicVilla.Utility;

namespace MagicVilla.Web.Services
{
    public class VillaNumberService : BaseService, IVillaNumberService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string _villaNumberUrl;
        public VillaNumberService(IHttpClientFactory httpClientFactory,IConfiguration configuration) : base(httpClientFactory)
        {
            _clientFactory = httpClientFactory;
            _villaNumberUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI");
        }

        public Task<T> CreateAsync<T>(VillaNumberCreateDTO dto, string token)
        {
            return SendAsync<T>(new APIRequest() 
            { 
                ApiType = StaticDetails.ApiType.POST,
                Data = dto,
                Url = _villaNumberUrl+ "/api/v1/VillaNumberAPI" + "/CreateVillaNumber",
                Token = token
            });
        }

        public Task<T> DeleteAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.DELETE,
                Url = _villaNumberUrl + "/api/v1/VillaNumberAPI" + "/DeleteVillaNumber/" + id,
                Token = token
            });
        }

        public Task<T> GetAllAsync<T>(string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.GET,
                Url = _villaNumberUrl + "/api/v1/VillaNumberAPI" + "/GetVillaNumbers",
                Token = token
            });
        }

        public Task<T> GetAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.GET,
                Url = _villaNumberUrl + "/api/v1/VillaNumberAPI" + "/GetVillaNumber/" + id,
                Token = token
            });
        }

        public Task<T> UpdateAsync<T>(VillaNumberUpdateDTO dto, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.PUT,
                Data = dto,
                Url = _villaNumberUrl + "/api/v1/VillaNumberAPI" + "/UpdateVillaNumber/" + dto.VillaNo,
                Token = token
            });
        }
    }
}
