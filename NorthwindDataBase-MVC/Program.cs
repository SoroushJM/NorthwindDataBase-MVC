using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NorthwindDataBase_MVC.Commands;
using NorthwindDataBase_MVC.Data;
using NorthwindDataBase_MVC.Models.Entity;
using NorthwindDataBase_MVC.Models.Services;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<FileContext>(options => options.UseSqlite(builder.Configuration["DefaultConnection"]));
builder.Services.AddScoped<CustomerRepository>();
builder.Services.AddScoped<Category>();
builder.Services.AddScoped<Customer>();
builder.Services.AddScoped<Employee>();
builder.Services.AddScoped<Order>();
builder.Services.AddScoped<OrderDetail>();
builder.Services.AddScoped<Product>();
builder.Services.AddScoped<Shipper>();
builder.Services.AddScoped<NewCustomerCommand>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddSwaggerGen();
builder.Services.AddRazorPages();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
//builder.Services.AddScoped(HttpClient);

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<FileContext>();

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
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
app.MapRazorPages();

app.Run();
