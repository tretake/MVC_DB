using Microsoft.EntityFrameworkCore;
using projeto_mvc.Data;
using projeto_mvc.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddDbContext<ProjetoContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString") ) );


builder.Services.AddScoped<IJogoSevice, JogoSevice>();
builder.Services.AddScoped<IPlataformaSevice, PlataformaSevice>();


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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



ProjetoDbInicializador.Seed(app);

app.Run();





