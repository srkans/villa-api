using AutoMapper;
using MagicVilla.Web.Models;
using MagicVilla.Web.Models.DTO;
using MagicVilla.Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MagicVilla.Web.Controllers
{

    public class VillaController : Controller
    {
        private readonly IVillaService _villaService;
        private readonly IMapper _mapper;

        public VillaController(IVillaService villaService, IMapper mapper)
        {
            _mapper = mapper;
            _villaService = villaService;
        }

        public async Task<IActionResult> IndexVilla()
        {
            List<VillaDTO> list = new List<VillaDTO>();

            var response = await _villaService.GetAllAsync<APIResponse>();

            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result));
            }

            return View(list);
        }
    }
}
