using AutoMapper;
using MagicVilla.VillaAPI.Models;
using MagicVilla.VillaAPI.Models.DTO;

namespace MagicVilla.VillaAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        { 
            CreateMap<Villa,VillaDTO>();
            CreateMap<VillaDTO, Villa>();

            CreateMap<Villa, VillaCreateDTO>().ReverseMap(); //reversemap kullanırsak iki kez yazmaya gerek kalmıyor.
            CreateMap<Villa, VillaUpdateDTO>().ReverseMap();

            CreateMap<VillaNumber, VillaNumberDTO>().ReverseMap();
            CreateMap<VillaNumber, VillaNumberCreateDTO>().ReverseMap(); 
            CreateMap<VillaNumber, VillaNumberUpdateDTO>().ReverseMap();

            CreateMap<ApplicationUser, UserDTO>().ReverseMap();
        }
    }
}
