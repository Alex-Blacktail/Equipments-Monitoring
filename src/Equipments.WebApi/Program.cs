using System.Reflection;
using Equipments.Application;
using Equipments.Application.Common.Mappings;
using Equipments.Application.Interfaces;
using Equipments.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(c =>
{
    c.AddProfile(new AssemblyMappingProfile(Assembly.GetExecutingAssembly()));
    c.AddProfile(new AssemblyMappingProfile(typeof(IEquipmentsDbContext).Assembly));
});

builder.Services.AddMediatr();
builder.Services.AddEquipmentsDbContext(builder.Configuration);

builder.Services.AddControllers();

builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseRouting();
app.UseHttpsRedirection();
app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

app.Run();