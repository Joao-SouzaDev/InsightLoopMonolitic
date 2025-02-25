using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightLoop.Domain.Entities
{
    public class Feedback
    {
        public Guid Id { get; private set; }
        public Guid ProductId { get; private set; }
        public Guid UserId { get; private set; }
        public string? Comment { get; private set; }
        public int Rating { get; private set; }
        public DateTime CreatedDate { get; private set; }

        //Constructor para criação do objeto Feedback
        public Feedback(Guid productId, Guid userId, string? comment, int rating)
        {
            Id = Guid.NewGuid();
            ProductId = productId;
            UserId = userId;
            SetRating(rating);
            SetComment(comment);
            CreatedDate = DateTime.Now;
        }
        //Regra para definir a avaliação entre 1 e 5
        private void SetRating(int rating)
        {
            if(rating < 1 || rating > 5)
            {
                throw new ArgumentException("Rating must be between 1 and 5");
            }
        }
        //Regra para comentário obrigatório para avaliações abaixo de 3
        private void SetComment(string? comment)
        {
            if(this.Rating < 3)
            {
                if (string.IsNullOrWhiteSpace(comment))
                {
                    throw new ArgumentException("Comment is required for ratings below 3");
                }
                Comment = comment;
            }
        }
    }
}
