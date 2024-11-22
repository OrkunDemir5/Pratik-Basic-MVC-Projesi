var builder = WebApplication.CreateBuilder(args);

// MVC servislerini ekliyoruz
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Statik dosya desteði
app.UseStaticFiles();

app.UseRouting();

// Varsayýlan rotayý ayarlýyoruz
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=CustomerOrders}/{action=Index}/{id?}");

app.Run();