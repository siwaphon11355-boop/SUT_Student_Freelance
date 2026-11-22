using Microsoft.AspNetCore.DataProtection;
using SutBackOffice.Components;
using SutBackOffice.Data;

var builder = WebApplication.CreateBuilder(args);

// Back Office is an interactive Blazor Server app (C# / .NET 8).
// It will call the ASP.NET Core 8 Web API (JWT) in a later phase; for now it runs on mock data.
builder.Services.AddDataProtection()
    .PersistKeysToFileSystem(new DirectoryInfo(Path.Combine(builder.Environment.ContentRootPath, ".keys")));
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddScoped<ShellState>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
