using AutoMapper;
using InsightLoop.Domain.Entities;
using InsightLoop.ProductServico.DTO;

namespace InsightLoop.ProductServico.Profiles
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
