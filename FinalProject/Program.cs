using FinalProject.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MemberContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MemberContext")));
builder.Services.AddDbContext<GamesContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("GamesContext")));
/*builder.Services.AddDbContext<MoviesContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MoviesContext")));
builder.Services.AddDbContext<SportsContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SportsContext")));*/

builder.Services.AddSwaggerDocument();


builder.Services.AddScoped<IMemberService, MemberService>();

builder.Services.AddScoped<IGamesService, GamesService>();

/*builder.Services.AddScoped<IMoviesService, MoviesService>();

builder.Services.AddScoped<ISportsService, SportsService>();*/


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

using (var scope = app.Services.CreateScope())
{
	var context = scope.ServiceProvider.GetRequiredService<MemberContext>();
	context.Database.EnsureCreated();
}

using (var scope = app.Services.CreateScope())
{
	var context = scope.ServiceProvider.GetRequiredService<GamesContext>();
	context.Database.EnsureCreated();
}

/*using (var scope = app.Services.CreateScope())
{
	var context = scope.ServiceProvider.GetRequiredService<MoviesContext>();
	context.Database.EnsureCreated();
}

using (var scope = app.Services.CreateScope())
{
	var context = scope.ServiceProvider.GetRequiredService<SportsContext>();
	context.Database.EnsureCreated();
}*/

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseOpenApi();
app.UseSwaggerUi3();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
