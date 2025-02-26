using InsightLoop.Domain.Entities;
using InsightLoop.Domain.Repositories;
namespace InsightLoop.Application.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void AddProduct(Product product)
        {
            _productRepository.Add(product);
        }
        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll();
        }
        public IEnumerable<Product> GetProductsByProductOwnerId(Guid productOwnerId)
        {
            return _productRepository.GetByProductOwnerId(productOwnerId);
        }
        public void UpdateProduct(Product product)
        {
            _productRepository.Update(product);
        }
        public void DeleteProduct(Product product)
        {
            _productRepository.Delete(product);
        }
        public Product GetProductById(Guid productId)
        {
            return _productRepository.GetByIdAsync(productId);
        }
    }
}
