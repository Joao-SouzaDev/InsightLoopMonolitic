using AutoMapper;
using InsightLoop.AuthService.DTO;
using InsightLoop.Domain.Entities;

namespace InsightLoop.AuthService.Profiles
{
    public class ProdutctProfile : Profile
    {
        public ProdutctProfile()
        {
            CreateMap<CreateProductRequest, Product>();
            CreateMap<Product, CreateProductResponse>();
            CreateMap<Product, GetProductResponse>();
            CreateMap<Product, UpdateProductResponse>();
        }
    }
}
