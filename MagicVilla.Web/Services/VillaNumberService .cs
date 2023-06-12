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

        public Task<T> CreateAsync<T>(VillaNumberCreateDTO dto)
        {
            return SendAsync<T>(new APIRequest() 
            { 
                ApiType = StaticDetails.ApiType.POST,
                Data = dto,
                Url = _villaNumberUrl+"/api/VillaNumberAPI"+ "/CreateVillaNumber"
            });
        }

        public Task<T> DeleteAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.DELETE,
                Url = _villaNumberUrl + "/api/VillaNumberAPI" + "/DeleteVillaNumber/" + id
            });
        }

        public Task<T> GetAllAsync<T>()
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.GET,
                Url = _villaNumberUrl + "/api/VillaNumberAPI" + "/GetVillaNumbers"
            });
        }

        public Task<T> GetAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.GET,
                Url = _villaNumberUrl + "/api/VillaNumberAPI" + "/GetVillaNumber/" + id
            });
        }

        public Task<T> UpdateAsync<T>(VillaNumberUpdateDTO dto)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.PUT,
                Data = dto,
                Url = _villaNumberUrl + "/api/VillaNumberAPI" + "/UpdateVillaNumber/" + dto.VillaNo
            });
        }
    }
}
