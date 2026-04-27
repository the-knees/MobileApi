using MobileApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// DB
builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseInMemoryDatabase("PostDb"));

// Controllers
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();