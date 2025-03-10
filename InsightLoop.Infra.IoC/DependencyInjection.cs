﻿using InsightLoop.Application.Services;
using InsightLoop.Domain.Repositories;
using InsightLoop.Infra.Data;
using InsightLoop.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InsightLoop.Infra.IoC
{
    public static class DependencyInjection
    {
        public static void AddDataContexts(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        }
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductOwnerRepository, ProductOwnerRepository>();
            services.AddScoped<IFeedBackRepository, FeedBackRepository>();
            services.AddScoped<ProductService>();
            services.AddScoped<ProductOwnerService>();
            services.AddScoped<FeedbackService>();
        }
    }
}
