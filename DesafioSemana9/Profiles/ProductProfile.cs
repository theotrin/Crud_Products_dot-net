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
    }
}
