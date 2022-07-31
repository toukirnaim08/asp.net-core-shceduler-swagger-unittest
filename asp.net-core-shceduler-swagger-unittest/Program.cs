using asp.net_core_shceduler_swagger_unittest_;
using asp.net_core_shceduler_swagger_unittest_.Models;
using asp.net_core_shceduler_swagger_unittest_.Services;

var builder = WebApplication.CreateBuilder(args);

//builder.Configuration.GetSection("Settings").Get<Configs>();
Configs.StatusURL = builder.Configuration.GetValue<string>("StatusURL");

// Add services to the container.
builder.Services.AddControllersWithViews();

// swagger
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IHttpProvider, HttpProvider>();
builder.Services.AddSingleton<IStatusService, StatusService>();

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

