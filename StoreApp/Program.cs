using StoreApp.Infrastructe.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();//artık controller olmadanda razor pageleri kullanabilecek bir servisi uygulamamıza dahil etmiş olduk.

builder.Services.ConfigureDbContext(builder.Configuration);

builder.Services.ConfigureSession();

builder.Services.ConfigureRepositoryRegisteration();

builder.Services.ConfigureServiceRegisteration();

builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

app.UseStaticFiles();
app.UseSession();

app.UseHttpsRedirection();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        name: "Admin",
        areaName: "Admin",
        pattern: "Admin/{controller=DashBoard}/{action=Index}/{id?}"
    );
    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

    endpoints.MapRazorPages();//Razor pagelerimiz için endpoint yapısını aktifleştirdik.
});

app.Run();
