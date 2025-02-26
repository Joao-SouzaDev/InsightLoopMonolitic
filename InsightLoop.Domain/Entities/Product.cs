using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightLoop.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string? Name { get; private set; }
        public string? Description { get; private set; }
        public decimal Price { get; private set; }
        public Guid ProductOwnerId { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public ProductOwner ProductOwner { get; private set; }
        public Product()
        {
            CreatedDate = DateTime.UtcNow;

        }
        //Construtor para criação do objeto Produto
        public Product(string? name, string? description, decimal price, Guid productOwnerId, ProductOwner productOwner)
        {
            Id = Guid.NewGuid();
            SetName(name);
            SetDescription(description);
            SetPrice(price);
            ProductOwnerId = productOwnerId;
            CreatedDate = DateTime.UtcNow;
            ProductOwner = productOwner;
        }
        //Regra para definir o nome do produto
        private void SetName(string? name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name is required");
            }
            Name = name;
        }
        //Regra para definir o preço do produto
        private void SetPrice(decimal price)
        {
            if (price <= 0)
            {
                throw new ArgumentException("Price must be greater than 0");
            }
            Price = price;
        }
        //Regra para definir a descrição do produto
        private void SetDescription(string? description)
        {
            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("Description is required");
            }
            Description = description;
        }
    }
}
