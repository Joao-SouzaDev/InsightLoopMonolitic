using AutoMapper;
using InsightLoop.AuthService.Controllers.DTO;
using InsightLoop.Domain.Entities;

namespace InsightLoop.AuthService.Controllers.Profiles
{
    public class FeedBackProfile : Profile
    {
        public FeedBackProfile()
        {
            CreateMap<CreateFeedBackRequest, Feedback>();
            CreateMap<Feedback, GetFeedBackResponse>();
        }
    }
}
