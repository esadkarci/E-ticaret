using MultiShop.Catalog.Dtos.ProductmageDtos;


namespace MultiShop.Catalog.Services.ProductImageServices
{
    public interface IProductImageService
    {
        Task<List<ResultProductmageDto>> GetAllCategoriesAsync();
        Task CreateProductImageAsync(CreateProductmageDto createProductImageDto);
        Task UpdateProductImageAsync(UpdateProductmageDto updateProductImageDto);
        Task DeleteProductImageAsync(string id);
        Task<GetByIdProductmageDto> GetByIdProductImageAsync(string id);
    }
}
