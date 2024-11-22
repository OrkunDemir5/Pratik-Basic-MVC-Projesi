var builder = WebApplication.CreateBuilder(args);

// MVC servislerini ekliyoruz
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Statik dosya deste�i
app.UseStaticFiles();

app.UseRouting();

// Varsay�lan rotay� ayarl�yoruz
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=CustomerOrders}/{action=Index}/{id?}");

app.Run();