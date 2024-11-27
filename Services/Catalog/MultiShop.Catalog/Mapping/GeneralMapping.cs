using AutoMapper;
using MultiShop.Catalog.Dtos.CategoryDtos;
using MultiShop.Catalog.Dtos.ProductDetailDtos;
using MultiShop.Catalog.Dtos.ProductDtos;
using MultiShop.Catalog.Dtos.ProductmageDtos;
using MultiShop.Catalog.Entities;

namespace MultiShop.Catalog.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping() 
        {
            CreateMap<Category,ResultCategoryDto > ().ReverseMap();
            CreateMap<Category,CreateCategoryDto > ().ReverseMap();
            CreateMap<Category,GetByIdCategoryDto > ().ReverseMap();
            CreateMap<Category,UpdateCategoryDto > ().ReverseMap();

            CreateMap<Product,UpdateProductDto>().ReverseMap();
            CreateMap<Product,ResultProductDto>().ReverseMap();
            CreateMap<Product,GetByIdProductDto>().ReverseMap();
            CreateMap<Product,CreateProductDto>().ReverseMap();

            CreateMap<ProductImage, UpdateProductmageDto>().ReverseMap();
            CreateMap<ProductImage, CreateProductmageDto>().ReverseMap();
            CreateMap<ProductImage, GetByIdProductmageDto>().ReverseMap();
            CreateMap<ProductImage, ResultProductmageDto>().ReverseMap();

            CreateMap<ProductDetail, ResultProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, GetByIdProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, CreateProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, UpdateProductDetailDto>().ReverseMap();
        }
    }
}
