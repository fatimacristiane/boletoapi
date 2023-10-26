using AutoMapper;
using boleto.api.DTO;
using boletoapi.business.Models;

namespace boleto.api.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Banco, BancoDTO>().ReverseMap();
            CreateMap<Boleto, BoletoDTO>().ReverseMap();

        }
        
    }
}
