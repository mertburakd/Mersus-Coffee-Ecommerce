using Buisness.Abstract;
using Buisness.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using WEBUI.JwtEntities;
using WEBUI.JwtEntities.Validations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddSingleton<ICardService, CardManager>();
builder.Services.AddSingleton<ICardDal, EfCardDal>();

builder.Services.AddSingleton<IOrderService, OrderManager>();
builder.Services.AddSingleton<IOrderDal, EfOrderDal>();
builder.Services.AddSingleton<IProductService, ProductManager>();
builder.Services.AddSingleton<IProductDal, EfProductDal>();


builder.Services.AddSingleton<ICategoryDal, EfCategoryDal>();
builder.Services.AddSingleton<ICategoryService, CategoryManager>();
builder.Services.AddSingleton<IAdressDal, EfAdressDal>();
builder.Services.AddSingleton<IAdressService, AdressManager>();



ConfigurationManager configuration = builder.Configuration;

builder.Services.AddDbContext<CustomIdentityDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("MyData")));

builder.Services.AddIdentity<CustomIdentityUser, CustomIdentityRole>(_ =>
{
    _.Password.RequiredLength = 5; //En az kaç karakterli olmasý gerektiðini belirtiyoruz.
    _.Password.RequireNonAlphanumeric = false; //Alfanumerik zorunluluðunu kaldýrýyoruz.
    _.Password.RequireLowercase = false; //Küçük harf zorunluluðunu kaldýrýyoruz.
    _.Password.RequireUppercase = false; //Büyük harf zorunluluðunu kaldýrýyoruz.
    _.Password.RequireDigit = false; //0-9 arasý sayýsal karakter zorunluluðunu kaldýrýyoruz.
    _.User.RequireUniqueEmail = true; //Email adreslerini tekilleþtiriyoruz.
    _.User.AllowedUserNameCharacters = "abcçdefghiýjklmnoöpqrsþtuüvwxyzABCÇDEFGHIÝJKLMNOÖPQRSÞTUÜVWXYZ0123456789-._@+"; //Kullanýcý adýnda geçerli olan karakterleri belirtiyoruz.
}).AddPasswordValidator<CustomPasswordValidation>()
     .AddUserValidator<CustomUserValidation>()
     .AddErrorDescriber<CustomIdentityErrorDescriber>().AddEntityFrameworkStores<CustomIdentityDbContext>()
     .AddDefaultTokenProviders();



builder.Services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
}));
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Swagger",
        Description = "Swagger MersusBiliþim",
    });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 1safsfsdfdfd\"",
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement {
        {
            new OpenApiSecurityScheme {
                Reference = new OpenApiReference {
                    Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});
builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.Name = "member_cookie";
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(90);
    options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
    options.SlidingExpiration = true;
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        //dagitici kontrol edilsin.
        ValidateIssuer = true,
        //alici kontol edilsin.
        ValidateAudience = true,
        //dagitici degerini appsettings.json'dan cekiyoruz.
        ValidIssuer = configuration["TokenOptions:Issuer"],
        //alici degerini appsettings.json'dan cekiyoruz.
        ValidAudience = configuration["TokenOptions:Audience"],
        //singinkey kontrol edilsin.
        ValidateIssuerSigningKey = true,
        //singin keyi appsettings.json'dan cekip byte arraye ceviriyoruz.
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(configuration["TokenOptions:SecurityKey"])),
      
    };
});
builder.Services.AddSession();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseRouting();
app.UseCors("MyPolicy");

app.UseAuthentication();
app.UseAuthorization();

app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseSwagger();

app.UseSwaggerUI(option =>
{
    option.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger");
    option.RoutePrefix = "swagger";
});

app.UseCookiePolicy();

app.UseStatusCodePages();


app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor |
    ForwardedHeaders.XForwardedProto
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
