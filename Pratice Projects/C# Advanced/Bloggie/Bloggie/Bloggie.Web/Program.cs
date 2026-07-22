using Bloggie.Web.Data;
using Bloggie.Web.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers(); //added the controllers to the service collection in order to use the API controllers in the project

builder.Services.AddDbContext<BloggieDbContext>(options => 
options.UseSqlServer(
    builder.Configuration.GetConnectionString("BloggieDbConnectionString")));//injected the connection string from appsettings.json into the BloggieDbContext using dependency injection

builder.Services.AddDbContext<AuthDbContext>(options => options
.UseSqlServer(builder.Configuration.GetConnectionString("BloggieAuthConnectionString")));//injected the connection string from appsettings.json into the AuthDbContext using dependency injection

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<AuthDbContext>(); //added the identity services to the service collection and specified that we want to use the AuthDb

builder.Services.Configure<IdentityOptions>(options =>
{
    //default password settings for the identity framework, you can change these settings as per your requirements
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 1;
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Login";
    options.AccessDeniedPath = "/AccessDenied"; //configure the application cookie settings for authentication,
                                                //specifying the login path and access denied path
});

builder.Services.AddScoped<IBlogPostRepository, BlogPostRepository>(); //inject the interface by using the class repository

builder.Services.AddScoped<IImageRepository, ImageRespositoryCloudinary>(); //inject the interface by using the class repository

builder.Services.AddScoped<ITagRepository, TagRepository>(); //inject the interface by using the class repository

builder.Services.AddScoped<IBlogPostLikeRepository, BlogPostLikeRepository>(); //inject the interface by using the class repository

builder.Services.AddScoped<IBlogPostCommentRepository, BlogPostCommentRepository>(); //inject the interface by using the class repository

builder.Services.AddScoped<IUserRepository, UserRepository>(); //inject the interface by using the class repository

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.MapControllers(); //map the controllers to the request pipeline

app.Run();
