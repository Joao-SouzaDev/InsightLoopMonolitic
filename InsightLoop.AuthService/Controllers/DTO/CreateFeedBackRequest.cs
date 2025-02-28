namespace InsightLoop.AuthService.Controllers.DTO
{
    public class CreateFeedBackRequest
    {
        public string? Name { get; set; }
        public Guid? ProductId { get; set; }
        public int Rating { get; set; }
    }
}
