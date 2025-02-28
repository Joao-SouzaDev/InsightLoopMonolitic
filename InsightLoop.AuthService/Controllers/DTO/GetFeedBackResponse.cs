using InsightLoop.AuthService.DTO;
using InsightLoop.Domain.Entities;

namespace InsightLoop.AuthService.Controllers.DTO
{
    public class GetFeedBackResponse
    {
        public string? Name { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public GetProductResponse Product { get; set; }

    }
}
