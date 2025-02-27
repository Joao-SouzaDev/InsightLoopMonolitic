using InsightLoop.Domain.Entities;
using InsightLoop.Infra.Data;
using InsightLoop.Infra.IoC;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDataContexts(builder.Configuration);
builder.Services.AddServices();
builder.Services.AddIdentityApiEndpoints<Usuario>().AddEntityFrameworkStores<ApplicationDbContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.MapGroup("auth").MapIdentityApi<Usuario>().WithTags("Autorização");
app.MapControllers();

app.Run();
