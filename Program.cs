var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

//app.MapDefaultControllerRoute();


//default root yerine 
app.MapControllerRoute(
    name:"default",
    pattern:"{Controller=Home}/{action=index}/{id?}"
);
app.Run();

