using BlazorServerAppDemo.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

ConfigureServices(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

static void ConfigureServices(IServiceCollection services)
{
    // Add services to the container.
    services.AddRazorPages();
    services.AddServerSideBlazor();
    //services.AddSingleton<ContactService, ContactService>();
    services.AddSingleton<IContactService, ContactServiceTesting>();
}
