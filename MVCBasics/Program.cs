var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(15);
});

var app = builder.Build();

app.UseSession();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "ajax",
    pattern: "ajax");

app.MapControllerRoute(
    name: "persons",
    pattern: "persons");

app.MapControllerRoute(
    name: "checkfever",
    pattern: "checkfever"
    );

app.MapControllerRoute(
    name: "guessinggame",
    pattern: "GuessingGame"
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
