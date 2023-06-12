using BoschBootcamp.BusinessLayer.Abstract;
using BoschBootcamp.BusinessLayer.BusinessRules;
using BoschBootcamp.BusinessLayer.Concrete;
using BoschBootcamp.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BBContext>();
builder.Services.AddScoped<IModelService, ModelManager>();
builder.Services.AddScoped<IAreaService, AreaManager>();
builder.Services.AddScoped<IInjectorService, InjectorManager>();
builder.Services.AddScoped<IDepartmentService, DepartmentManager>();
builder.Services.AddScoped<IOrderDetailService, OrderDetailManager>();
builder.Services.AddScoped<IOrderService, OrderManager>();
builder.Services.AddScoped<ISectionService, SectionManager>();
builder.Services.AddScoped<IStationService, StationManager>();
builder.Services.AddScoped<IStationProcessService, StationProcessManager>();
builder.Services.AddScoped<ISubcomponentService, SubcomponentManager>();
builder.Services.AddScoped<ISubcomponentTypesService, SubcomponentTypesManager>();
builder.Services.AddScoped<ModelsBusinessRule>();
builder.Services.AddScoped<InjectorBusinessRule>();
builder.Services.AddScoped<OrderBusinessRule>();
builder.Services.AddScoped<OrderDetailBusinessRules>();
builder.Services.AddScoped<StationProcessBusinessRule>();
builder.Services.AddCors(c => c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin()));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
