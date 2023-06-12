using MagicVilla.Web.Models.DTO;
using MagicVilla.Web.Services.IServices;
using MagicVilla.Web.Models;
using MagicVilla.Utility;

namespace MagicVilla.Web.Services
{
    public class VillaService : BaseService, IVillaService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string _villaUrl;
        public VillaService(IHttpClientFactory httpClientFactory,IConfiguration configuration) : base(httpClientFactory)
        {
            _clientFactory = httpClientFactory;
            _villaUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI");
        }

        public Task<T> CreateAsync<T>(VillaCreateDTO dto)
        {
            return SendAsync<T>(new APIRequest() 
            { 
                ApiType = StaticDetails.ApiType.POST,
                Data = dto,
                Url = _villaUrl+"/api/VillaAPI"+ "/CreateVilla"
            });
        }

        public Task<T> DeleteAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.DELETE,
                Url = _villaUrl + "/api/VillaAPI" + "/DeleteVilla/"+id
            });
        }

        public Task<T> GetAllAsync<T>()
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.GET,
                Url = _villaUrl + "/api/VillaAPI" + "/GetVillas"
            });
        }

        public Task<T> GetAsync<T>(int id)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.GET,
                Url = _villaUrl + "/api/VillaAPI" + "/GetVilla/" + id
            });
        }

        public Task<T> UpdateAsync<T>(VillaUpdateDTO dto)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = StaticDetails.ApiType.PUT,
                Data = dto,
                Url = _villaUrl + "/api/VillaAPI" + "/UpdateVilla/" + dto.Id
            });
        }
    }
}
