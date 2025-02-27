using InsightLoop.Domain.Entities;
using InsightLoop.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightLoop.Application.Services
{
    public class ProductOwnerService
    {
        private readonly IProductOwnerRepository _productOwnerRepository;
        public ProductOwnerService(IProductOwnerRepository productOwnerRepository)
        {
            _productOwnerRepository = productOwnerRepository;
        }
        public void AddProductOwner(ProductOwner productOwner)
        {
            _productOwnerRepository.Add(productOwner);
        }
        public IEnumerable<ProductOwner> GetAll()
        {
            return _productOwnerRepository.GetAll();
        }
        public ProductOwner GetProductOwnerById(Guid productOwnerId)
        {
            return _productOwnerRepository.GetByIdAsync(productOwnerId);
        }
        public void UpdateProductOwner(ProductOwner productOwner)
        {
            _productOwnerRepository.Update(productOwner);
        }
        public void DeleteProductOwner(ProductOwner productOwner)
        {
            _productOwnerRepository.Delete(productOwner);
        }
    }
}
