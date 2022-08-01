using Microsoft.EntityFrameworkCore;

using asp.net_core_shceduler_swagger_unittest;
using asp.net_core_shceduler_swagger_unittest.Data;
using asp.net_core_shceduler_swagger_unittest.Models;
using asp.net_core_shceduler_swagger_unittest.Services;

var builder = WebApplication.CreateBuilder(args);

// Set Configs
Configs.TzStatsStatus = builder.Configuration.GetValue<string>("TzStatsStatus");
Configs.TzStatsTickers = builder.Configuration.GetValue<string>("TzStatsTickers");

// Add services to the container.
builder.Services.AddControllersWithViews();

// swagger
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IHttpProvider, HttpProvider>();
builder.Services.AddSingleton<ITzStatService, TzStatService>();

builder.Services.AddDbContext<ExtendedDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

