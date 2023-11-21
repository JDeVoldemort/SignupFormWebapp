using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using C_Website.Data;
using C_Website.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
/*using Microsoft.AspNetCore.Authentication.OpenIdConnect;*/

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
/*builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
    *//*    options.DefaultChallengeScheme = GoogleDefaults.AuthenticationScheme;*//*
})*/
  /*  .AddCookie()
.AddOpenIdConnect(options =>
{
    options.ClientId = builder.Configuration["Authentication:Google:ClientId"];
    options.ClientSecret = builder.Configuration["Authentication:Google:ClientSecret"];
    options.Authority = "https://accounts.google.com";
    options.ResponseType = "code";
    options.SaveTokens = true;
    options.GetClaimsFromUserInfoEndpoint = true;
    options.Scope.Add("openid");
    options.Scope.Add("profile");
    options.Scope.Add("email");
});*/
/*.AddCookie()
.AddGoogle(options =>
{
    options.ClientId = builder.Configuration["Authentication:Google:ClientId"];
    options.ClientSecret = builder.Configuration["Authentication:Google:ClientSecret"];
});
*/
builder.Services.AddRazorPages();

builder.Services.AddRazorPages();
builder.Services.AddDbContext<C_WebsiteContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("C_WebsiteContext") ?? throw new InvalidOperationException("Connection string 'C_WebsiteContext' not found.")));
/*builder.Services.AddDatabaseDeveloperPageExceptionFilter();*/
var app = builder.Build();
// added the next lines to seed data
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

   /* SeedData.Initialize(services);*/
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
/*else
{
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}*/
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<C_WebsiteContext>();
    context.Database.EnsureCreated();
    /*DbInitializer.Initialize();*/
}
/*app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
});*/
app.MapRazorPages();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.Run();
