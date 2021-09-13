using ItvTicketsService.Client.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MudBlazor.Services;

namespace ItvTicketsService.Client
{
    //public class Startup
    //{

    //    // This method gets called by the runtime. Use this method to add services to the container.
    //    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    //    public void ConfigureServices(IServiceCollection services)
    //    {
    //        services.AddBlazoredLocalStorage();
    //        services.AddAuthorizationCore();
    //    }

    //    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    //    public async void Configure(string[] args)
    //    {
    //        var builder = WebAssemblyHostBuilder.CreateDefault(args);
    //        builder.RootComponents.Add<App>("app");

    //        await builder.Build().RunAsync();
    //    }
    //}
}
