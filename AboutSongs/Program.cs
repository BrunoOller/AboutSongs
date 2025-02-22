using AboutSongs.Data;
using AboutSongs.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string conn = builder.Configuration.GetConnectionString("AboutSongsConn");
var versao = ServerVersion.AutoDetect(conn);
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseMySql(conn, versao)
);

builder.Services.AddIdentity<IdentityUser, IdentityRole>(
    opt => opt.SignIn.RequireConfirmedEmail = false
)
.AddEntityFrameworkStores<AppDbContext>()
.AddDefaultTokenProviders();


// Registre o IUsuarioService
builder.Services.AddScoped<IEmailSender, EmailSender>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IMusicService, MusicService>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
