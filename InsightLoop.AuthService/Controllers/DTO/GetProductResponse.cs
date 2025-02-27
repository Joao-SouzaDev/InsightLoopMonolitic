﻿namespace InsightLoop.AuthService.DTO
{
    public class GetProductResponse
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
    }
}
