using AutoMapper;
using DesafioSemana9.Data.Dtos;
using DesafioSemana9.Models;

namespace DesafioSemana9.Profiles;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        
        CreateMap<CreateProductDto, Product>();
        CreateMap<UpdateProductDto, Product>();
        CreateMap<CreateAddressDto, Address>();
        CreateMap<Address, ReadAddressDto>();
        CreateMap<CreateClientDto, Client>();
        CreateMap<Client, ReadClientDto>()
            .ForMember(clientDto => clientDto.ReadAddressDto,
                    opt => opt.MapFrom(clientDto => clientDto.Address))
                .ForMember(clientDto => clientDto.ReadAddressDto,
                    opt => opt.MapFrom(clientDto => clientDto.Address)); ;
    }
}
