using Microsoft.EntityFrameworkCore;
using Business;
using Core;
using Core.Internal;
using DataAccess;
using DataAccess.Generic;
using DataAccess.UnitOfWorkConcrete;
using Business.Services; 

var builder = WebApplication.CreateBuilder(args);

 
builder.Services.AddDbContext<AppDbCon>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        b => b.MigrationsAssembly("WebAPI")
    )
);

 
builder.Services.AddScoped<IkisiServis, kisiServis>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

 
builder.Services.AddScoped<CinsiyetService>();
builder.Services.AddScoped<DoktorKabulDurumuServices>();
builder.Services.AddScoped<DoktorKayitService>();
builder.Services.AddScoped<MisafirService>();
builder.Services.AddScoped<KabulListeServices>();
builder.Services.AddScoped<KayitliKisiListeService>();
builder.Services.AddScoped<MhrsKayitServices>();

builder.Services.AddScoped<TamamlanmaDurumuService>();


 
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

 
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

 
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbCon>();
    context.Database.Migrate();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
