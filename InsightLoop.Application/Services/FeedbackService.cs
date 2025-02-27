using InsightLoop.Domain.Entities;
using InsightLoop.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightLoop.Application.Services
{
    public class FeedbackService
    {
        private readonly IFeedBackRepository _feedbackRepository;
        public FeedbackService(IFeedBackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }
        public void AddFeedback(Feedback feedback)
        {
            _feedbackRepository.Add(feedback);
        }
        public IEnumerable<Feedback> GetAll()
        {
            return _feedbackRepository.GetAll();
        }
        public Feedback? GetFeedbackById(Guid feedbackId)
        {
            return _feedbackRepository.GetByIdAsync(feedbackId);
        }
        public void UpdateFeedback(Feedback feedback)
        {
            _feedbackRepository.Update(feedback);
        }
        public void DeleteFeedback(Feedback feedback)
        {
            _feedbackRepository.Delete(feedback);
        }

    }
}
