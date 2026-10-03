using Salinto;
using Salinto.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents().AddInteractiveServerComponents();

builder.Services.AddScoped<IProfileService, InMemoryProfileService>();
builder.Services.AddScoped<ICompanyService, InMemoryCompanyService>();
builder.Services.AddScoped<IUserActivityService, InMemoryUserActivityService>();

var app = builder.Build();

app.UseStaticFiles();
app.UseAntiforgery();
app.MapRazorComponents<App>().AddInteractiveServerRenderMode();
app.Run();
