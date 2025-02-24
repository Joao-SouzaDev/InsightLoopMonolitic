using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightLoop.Domain.Entities
{
    sealed class ProductOwner
    {
        public Guid Id { get; private set; }
        public Guid UserId { get; private set; }
        public IUser User { get; private set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
        public ProductOwner(Guid userId, IUser user)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            User = user;
        }
    }
}
