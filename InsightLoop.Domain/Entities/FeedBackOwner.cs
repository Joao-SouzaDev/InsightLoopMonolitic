using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightLoop.Domain.Entities
{
    sealed class FeedBackOwner
    {
        public Guid Id { get; private set; }
        public IUser User { get; private set; }
        public Guid UserId { get; private set; }
        public ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
        public FeedBackOwner(Guid userId,IUser user)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            User = user;
        }
    }
}
