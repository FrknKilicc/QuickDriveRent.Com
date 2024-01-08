using QuickDriveRentCom.Application.Features.CQRS.Handlers.AboutHandler;
using QuickDriveRentCom.Application.Features.CQRS.Handlers.BannerHandler;
using QuickDriveRentCom.Application.Features.CQRS.Handlers.BrandHandler;
using QuickDriveRentCom.Application.Features.CQRS.Handlers.CarHandler;
using QuickDriveRentCom.Application.Features.CQRS.Handlers.CategoryHandler;
using QuickDriveRentCom.Application.Features.CQRS.Handlers.ContactHandler;
using QuickDriveRentCom.Application.Interfaces;
using QuickDriveRentCom.Application.Interfaces.CarInterfaces;
using QuickDriveRentCom.Application.Services;
using QuickDriveRentDomainPersistance.Context;
using QuickDriveRentDomainPersistance.Repositories;
using QuickDriveRentDomainPersistance.Repositories.CarRepositories;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<QuickDriveRentComContext>();
builder.Services.AddScoped(typeof(IRepository<>),typeof (Repository<>));
builder.Services.AddScoped(typeof(ICarRepository),typeof (CarRepository));

builder.Services.AddScoped<GetAboutByIdQueryHandler>();
builder.Services.AddScoped<GetAboutQueryHandler>();
builder.Services.AddScoped<CreateAboutCommandHandler>();
builder.Services.AddScoped<UpdateAboutCommandHandler>();
builder.Services.AddScoped<RemoveAboutCommandHandler>();


builder.Services.AddScoped<GetBannerQueryHandler>();
builder.Services.AddScoped<CreateBannerCommandHandler>();
builder.Services.AddScoped<GetBannerByIdQueryHandler>();
builder.Services.AddScoped<UpdateBannerCommandHandler>();
builder.Services.AddScoped<RemoveBannerCommandHandler>();


builder.Services.AddScoped<GetBrandQueryHandler>();
builder.Services.AddScoped<CreateBrandCommandHandler>();
builder.Services.AddScoped<GetBrandByIdQueryHandler>();
builder.Services.AddScoped<UpdateBrandCommandHandler>();
builder.Services.AddScoped<RemoveBrandCommandHandler>();

builder.Services.AddScoped<GetCarQueryHandler>();
builder.Services.AddScoped<CreateCarCommandHandler>();
builder.Services.AddScoped<GetCarByIdQueryHandler>();
builder.Services.AddScoped<UpdateCarCommandHandler>();
builder.Services.AddScoped<RemoveCarCommandHandler>();
builder.Services.AddScoped<GetCarWithBrandQueryHandler>();
builder.Services.AddScoped<GetLast5CarsWithBrandQueryHandler>();

builder.Services.AddScoped<GetCategoryQueryHandler>();
builder.Services.AddScoped<CreateCategoryCommandHandler>();
builder.Services.AddScoped<GetCategoryByIdQueryHandler>();
builder.Services.AddScoped<UpdateCategoryCommandHandler>();
builder.Services.AddScoped<RemoveCategoryCommandHandler>();

builder.Services.AddScoped<GetContactQueryHandler>();
builder.Services.AddScoped<CreateContactCommandHandler>();
builder.Services.AddScoped<GetContactByIdQueryHandler>();
builder.Services.AddScoped<UpdateContactCommandHandler>();
builder.Services.AddScoped<RemoveContactCommandHandler>();

builder.Services.AddScoped<RemoveContactCommandHandler>();


builder.Services.AddApplicationService(builder.Configuration);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
