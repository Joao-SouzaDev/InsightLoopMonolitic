using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightLoop.Domain.Entities
{
    public class Feedback
    {
        public Guid Id { get; private set; }
        public Guid ProductId { get; private set; }
        public string? UserEmail { get; private set; }
        public string? UserName { get; private set; }
        public string? Comment { get; private set; }
        public int Rating { get; private set; }
        public DateTime CreatedDate { get; private set; }

        //Constructor para criação do objeto Feedback
        public Feedback(Guid productId, string userEmail, string? comment, int rating,string userName)
        {
            Id = Guid.NewGuid();
            ProductId = productId;
            SetEmail(userEmail);
            SetUserName(userName);
            SetRating(rating);
            SetComment(comment);
            CreatedDate = DateTime.Now;
        }

        private void SetUserName(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                throw new ArgumentNullException(nameof(userName));
            }
            UserName = userName;
        }

        private void SetEmail(string userEmail)
        {
            if (string.IsNullOrWhiteSpace(userEmail))
            {
                throw new ArgumentNullException(nameof(userEmail));
            }
            UserEmail = userEmail;
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
